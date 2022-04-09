using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace tewst.Items.Weapons.Melee
{
    public class Manipulater : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gleam Manipulater");
            Tooltip.SetDefault("Every 3rd Swing fires a bolt.");
        }
        public override void SetDefaults()
        {
            Item.damage = 12;
            Item.DamageType = DamageClass.Melee;
            Item.rare = ItemRarityID.Green;
            Item.height = 36;
            Item.width = 36;
            Item.useAnimation = 7;
            Item.useTime = 7;
            Item.knockBack = 4.2f;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.noUseGraphic = true;
           // Item.noMelee = true;
            Item.UseSound = SoundID.Item30;
            Item.value = Item.buyPrice(0, 0, 8, 50);
            Item.channel = true;
            Item.shoot = ModContent.ProjectileType<Projectiles.Melee.LeanManipulaterP>();
            Item.shootSpeed = 5;
        }
    }
}
