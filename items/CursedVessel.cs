using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace tewst.Items
{
    public class CursedVessel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed Vessel");
            Tooltip.SetDefault("The pot feels a bit null.");
        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 20;
            Item.DamageType = DamageClass.Magic;
            Item.damage = 22;
            Item.crit = 0;
            Item.mana = 12;
            Item.noMelee = true;
            Item.rare = ItemRarityID.Orange;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item103;
            Item.useTime = 23;
            Item.useAnimation = 19;

            Item.shoot = ModContent.ProjectileType<Projectiles.Lightning>();
            Item.shootSpeed = 125f;
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            const int numP = 3;

            for (int i = 0; i < numP; i++)
            {
                Vector2 NumV = velocity.RotatedByRandom(MathHelper.ToRadians(45));
                NumV *= 2;

                Projectile.NewProjectileDirect(source, position, NumV, type, damage, knockback, player.whoAmI);
            }

            return false;
        }
    }
}

