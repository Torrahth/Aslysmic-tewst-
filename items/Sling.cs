using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Audio;
using Terraria.DataStructures;

namespace tewst.Items
{
    public abstract class Sling : ModProjectile
    {
        public virtual void SetStats(ref int chargeMAX, ref float chargeSpeed, ref int Dusttype)
        {

        }
        int chargeMAX = 10;
        float chargeSpeed = 0.2f;
        int Dusttype = 1;

        public bool Shot = false;
        public float spped = 0;
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            player.itemTime = 2;
            player.itemAnimation = 2;
            Projectile.position = Main.LocalPlayer.Center;
            if (player.channel == true)
            {
                if (spped >= chargeMAX)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Vector2 speed = Main.rand.NextVector2Circular(1, 1);
                        Dust d = Dust.NewDustPerfect(player.Center + speed * 180, DustID.Enchanted_Pink, speed * 8, Scale: 1.2f);
                        d.noGravity = true;
                    }
                }
                else
                {
                    for (int i = 0; i < 1; i++)
                    {
                        Vector2 speed = Main.rand.NextVector2CircularEdge(1, 1);
                        Dust d = Dust.NewDustPerfect(player.Center + speed * 82, Dusttype, speed * -6, Scale: 0.5f);
                        d.noGravity = true;
                    }
                }
                Projectile.velocity = Vector2.Zero;
                Projectile.position = player.position;
                spped += (float)chargeSpeed;
                MathHelper.Clamp(spped, -1, chargeMAX);
                if (spped > chargeMAX)
                {
                    spped = chargeMAX;
                }
                player.itemTime = 15;
                player.itemAnimation = 15;

            }
            else
            {
                Projectile.velocity = Vector2.One + new Vector2(spped);
                Shot = true;
            }
            if (Shot == true)
            {
                Projectile.Kill();
            }
        }
    }
}
