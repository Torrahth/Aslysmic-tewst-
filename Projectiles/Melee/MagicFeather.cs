using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace tewst.Projectiles.Melee
{
    public class MagicFeather : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glean Manipulater");
        }
        public override void SetDefaults()
        {
            var p = Projectile;
            p.width = 20;
            p.height = 20;
            p.penetrate = 1;
            p.friendly = true;
            p.hostile = false;
            p.timeLeft = 20;
            p.aiStyle = 1;
            p.light = 0.1f;
            p.alpha = 25;
            p.scale = 0.4f;
            p.extraUpdates = 1;
        }
        public override void Kill(int timeLeft)
        {
            for (int d = 0; d < 4; d++)
            {
                Vector2 spped = Main.rand.NextVector2CircularEdge(0.3f, 0.3f);
                Dust d2 = Dust.NewDustPerfect(Projectile.Center + new Vector2(0.5f, 0), DustID.Firework_Blue, spped.RotatedBy(Projectile.rotation + 45) * 4, 30, default);
                d2.noGravity = true;
            }
            Terraria.Audio.SoundEngine.PlaySound(SoundID.Dig, 21);
        }
    }
}
