using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
namespace tewst.Projectiles.Melee
{
    public class LeanManipulaterP : ModProjectile
    {
        public override string Texture => "tewst/Items/Weapons/Melee/Manipulater";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glean Manipulater");
        }
        public override void SetDefaults()
        {
            var p = Projectile;
            p.width = 38;
            p.height = 38;
            p.penetrate = -1;
            p.tileCollide = false;
            p.friendly = true;
            p.hostile = false;
            p.ignoreWater = true;
            p.timeLeft = 90;
            p.aiStyle = -1;
            p.light = 0.4f;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            var ROtaion = Projectile.rotation = Projectile.AngleTo(Main.MouseWorld);
            Projectile.ai[1] = ROtaion;
            /*  if (Main.mouseLeft == false)
              {
                  Projectile.Kill();
              }*/
            player.itemAnimation = 2;
            player.itemTime = 2;
            var Rot = Projectile.ai[1];
            Projectile.position = player.Center + new Vector2(50f, 6f).RotatedBy(Projectile.ai[1]);
            Projectile.position.X -= Projectile.width / 2;
            Projectile.position.Y -= Projectile.height / 2;
            Projectile.rotation = Rot + 45;
            if (Main.rand.NextBool(5))
            {
                Dust.NewDust(Projectile.Center, Projectile.width, Projectile.height, DustID.Ice, Projectile.velocity.X, Projectile.velocity.Y, 30, default);
            }
        /*    if ( Main.rand.NextBool(6))
            {
                for (int d = 0; d < 3; d++)
                {
                    Vector2 spped = Main.rand.NextVector2CircularEdge(0.2f, 0.2f);
                    Dust d2 = Dust.NewDustPerfect(Projectile.Center + new Vector2(0.5f, 0), DustID.Firework_Blue, spped.RotatedBy(Rot) * 4, 30, default);
                }
                Projectile.NewProjectile(Projectile.GetProjectileSource_FromThis(), Projectile.Center, new Vector2(16f, 0f).RotatedBy(Projectile.rotation = Projectile.AngleTo(Main.MouseWorld)), ModContent.ProjectileType<MagicFeather>(), Projectile.damage / 2, Projectile.knockBack / 2, player.whoAmI);
            }*/
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            for (int d = 0; d < 13; d++)
            {
                Vector2 spped = Main.rand.NextVector2CircularEdge(0.3f,0.6f);
                Dust d2 = Dust.NewDustPerfect(Projectile.Center + new Vector2(0.5f, 0), DustID.Firework_Blue, spped.RotatedBy(Projectile.rotation + 45) * 4, 30, default);
                d2.noGravity = true;
            }
        }
        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            for (int d = 0; d < 13; d++)
            {
                Vector2 spped = Main.rand.NextVector2CircularEdge(0.3f, 0.6f);
                Dust d2 = Dust.NewDustPerfect(Projectile.Center + new Vector2(0.5f, 0), DustID.Firework_Blue, spped.RotatedBy(Projectile.rotation + 45) * 4, 30, default);
                d2.noGravity = true;
            }
        }
        public override void Kill(int timeLeft)
        {
            for (int d = 0; d < 25; d++)
            {
                Vector2 spped = Main.rand.NextVector2CircularEdge(0.5f, 0.5f);
                Dust d2 = Dust.NewDustPerfect(Projectile.Center + new Vector2(0.5f, 0), DustID.Firework_Blue, spped.RotatedBy(Projectile.rotation + 45) * 4, 30, default);
                d2.noGravity = true;
            }
            for (int d = 0; d < 3; d++)
            {
                Vector2 spped = Main.rand.NextVector2CircularEdge(0.2f, 0.2f);
                Dust d2 = Dust.NewDustPerfect(Projectile.Center + new Vector2(0.5f, 0), DustID.Firework_Blue, spped.RotatedBy(Projectile.rotation + 45) * 4, 30, default);
            }
            Projectile.NewProjectile(Projectile.GetProjectileSource_FromThis(), Projectile.Center, new Vector2(16f, 0f).RotatedBy(Projectile.rotation = Projectile.AngleTo(Main.MouseWorld)), ModContent.ProjectileType<MagicFeather>(), Projectile.damage / 2, Projectile.knockBack / 2, Projectile.owner);
        }
    }
}
