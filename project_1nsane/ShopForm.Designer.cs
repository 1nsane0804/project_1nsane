```csharp
using System;
using System.Windows.Forms;
using ProjectInsane.Classes;
using ProjectInsane.Classes.Generators;

namespace ProjectInsane
{
  public partial class ShopForm : Form
  {
    private Player _player;
    private WeaponGenerator _weaponGenerator = new WeaponGenerator();
    private ArmorGenerator _armorGenerator = new ArmorGenerator();
    private bool _isWeaponShop;

    public ShopForm(Player player)
    {
      InitializeComponent();
      _player = player;
      InitializeShop();
    }

    private void InitializeShop()
    {
      Random random = new Random();
      _isWeaponShop = random.Next(2) == 0;

      lblShopType.Text = _isWeaponShop ? "Weapon Shop" : "Armor Shop";
      lstItems.Items.Clear();

      if (_isWeaponShop)
      {
        var weapons = _weaponGenerator.GenerateWeapons(5);
        foreach (var weapon in weapons)
        {
          lstItems.Items.Add($"{weapon.Name} - Attack: {weapon.AttackBonus} - Price: {weapon.Price} Gold");
        }
      }
      else
      {
        var armors = _armorGenerator.GenerateArmors(5);
        foreach (var armor in armors)
        {
          lstItems.Items.Add($"{armor.Name} - Defense: {armor.DefenseBonus} - Price: {armor.Price} Gold");
        }
      }
    }

    private void btnBuy_Click(object sender, EventArgs e)
    {
      if (lstItems.SelectedIndex == -1)
      {
        MessageBox.Show("Please select an item to buy.");
        return;
      }

      if (_isWeaponShop)
      {
        var weapons = _weaponGenerator.GenerateWeapons(5);
        var selectedWeapon = weapons[lstItems.SelectedIndex];

        if (_player.Gold >= selectedWeapon.Price)
        {
          _player.Gold -= selectedWeapon.Price;
          _player.Weapon = selectedWeapon;
          MessageBox.Show($"You bought {selectedWeapon.Name}!");
          Close();
        }
        else
        {
          MessageBox.Show("Not enough gold!");
        }
      }
      else
      {
        var armors = _armorGenerator.GenerateArmors(5);
        var selectedArmor = armors[lstItems.SelectedIndex];

        if (_player.Gold >= selectedArmor.Price)
        {
          _player.Gold -= selectedArmor.Price;
          _player.Armor = selectedArmor;
          MessageBox.Show($"You bought {selectedArmor.Name}!");
          Close();
        }
        else
        {
          MessageBox.Show("Not enough gold!");
        }
      }
    }
  }
}
```