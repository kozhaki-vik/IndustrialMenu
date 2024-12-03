using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustrialMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.ClientSize = new Size(840, 815);
            this.Text = "Industrial Menu by kozhaki";
            this.BackColor = Color.Gray;

            string imagePath = Application.StartupPath + @"\img\image.png";

            if (!File.Exists(imagePath))
            {
                MessageBox.Show($"Файл изображения не найден: {imagePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(830, 450),
                Location = new Point(5, 5),
                SizeMode = PictureBoxSizeMode.StretchImage, // Восстановлено растягивание изображения
                Image = Image.FromFile(imagePath)
            };

            this.Controls.Add(pictureBox);

            var buttonCategories = new (string ButtonText, string DataToCopy)[]
                        {
                ("Шприцы", @"[
  {
    ""TargetCategory"": 6,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  }
]"),

                ("Одежда", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shoes.boots""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pants""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""roadsign.kilt""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hoodie""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""jacket""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""roadsign.jacket""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.plate.torso""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""coffeecan.helmet""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.facemask""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""burlap.gloves""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""tactical.gloves""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""roadsign.gloves""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""wood.armor.pants""
  }
]")
,
                ("Антирад", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hazmatsuit""
  }
]")
,
                ("Рюкзаки", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""largebackpack""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""smallbackpack""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""nightvisiongoggles""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""heavy.plate.helmet""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""heavy.plate.jacket""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""heavy.plate.pants""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""diving.mask""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""diving.tank""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""diving.fins""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""diving.wetsuit""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""speargun.spear""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""speargun""
  }
]")
,
                ("9mm + 5.56mm", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.pistol""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rifle""
  }
]")
,
                ("Патроны", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.handmade.shell""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rifle.hv""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.pistol.hv""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rifle.incendiary""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.pistol.fire""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.shotgun""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.shotgun.slug""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""submarine.torpedo.straight""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rocket.seeker""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.grenadelauncher.buckshot""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.grenadelauncher.smoke""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.shotgun.fire""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""arrow.bone""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""arrow.fire""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""arrow.hv""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""arrow.wooden""
  }
]")
,
                ("АК-47", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rifle.ak""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rifle.lr300""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""lmg.m249""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hmlmg""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""minigun""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rifle.l96""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shotgun.m4""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""multiplegrenadelauncher""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rifle.bolt""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rocket.launcher""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""homingmissile.launcher""
  }
]")
,
                ("MP5", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""smg.mp5""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rifle.m39""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pistol.python""
  }
]")
,
                ("Thompson", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""smg.thompson""
  }
]")
,
                ("Semi", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rifle.semiauto""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rifle.sks""
  }
]")
,
                ("Двушка", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shotgun.double""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shotgun.pump""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""t1_smg""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pistol.nailgun""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""paddle""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""longsword""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""salvaged.sword""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""torch""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rock""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""spear.wooden""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""knife.bone""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""flashlight.held""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""salvaged.cleaver""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""crossbow""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""sickle""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""mace""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""machete""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pistol.eoka""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pistol.semiauto""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pistol.prototype17""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pistol.m92""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""smg.2""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pistol.water""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shotgun.spas12""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""revolver.hc""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pistol.revolver""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shotgun.waterpipe""
  }
]"),

                ("Взрывка", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""explosives""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""explosive.timed""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rifle.explosive""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rocket.fire""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""grenade.beancan""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""grenade.f1""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""grenade.flashbang""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""explosive.satchel""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rocket.basic""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rocket.mlrs""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rocket.seeker""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rocket.hv""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rocket.sam""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.grenadelauncher.he""
  }
]"),
                ("Руда", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""sulfur.ore""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.ore""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hq.metal.ore""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""crude.oil""
  }
]")
,
                ("Дерево", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""wood""
  }
]"),

                ("Камень", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""stones""
  }
]"),

                ("Уголь", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""charcoal""
  }
]"),

                ("Сера+Порох", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""sulfur""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""gunpowder""
  }
]"),

                ("Метал", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.refined""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.fragments""
  }
]"),
                ("Компоненты", @"[
  {
    ""TargetCategory"": 13,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""cctv.camera""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""targeting.computer""
  }
]"),

                ("Еда", @"[
  {
    ""TargetCategory"": 7,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  }
]"),

                ("Инструменты", @"[
  {
    ""TargetCategory"": 5,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  }
]"),

                ("Постройки", @"
[
  {
    ""TargetCategory"": 1,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  },
  {
    ""TargetCategory"": 9,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  },
  {
    ""TargetCategory"": 17,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  },
  {
    ""TargetCategory"": 16,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  },
  {
    ""TargetCategory"": 2,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  },
  {
    ""TargetCategory"": 10,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": """"
  }
]"),
                ("Карточки", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""keycard_blue""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""keycard_green""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""keycard_red""
  }
]"),

                ("Одежда хлам", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""tshirt.long""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pants.shorts""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shirt.collared""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""riot.helmet""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""bucket.helmet""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""deer.skull.mask""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""boots.frog""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""attire.hide.pants""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""attire.hide.poncho""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""attire.hide.vest""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""burlap.shoes""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""burlap.trousers""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hat.wolf""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""clatter.helmet""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""attire.hide.boots""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""wood.armor.helmet""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hat.miner""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hat.candle""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hat.beenie""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shirt.tanktop""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hat.boonie""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""burlap.gloves.new""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""mask.bandana""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""mask.balaclava""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""burlap.shirt""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""tshirt""
  }
]"),

                ("9mm Подача", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 2000,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""gunpowder""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 2000,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.fragments""
  }
]"),

                ("9mm Сбор", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 768,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.pistol""
  }
]"),

                ("5.56mm Подача", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 2000,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""gunpowder""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 2000,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.fragments""
  }
]"),

                ("5.56mm Сбор", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 768,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rifle""
  }
]"),

                ("Шприцы Подача", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1000,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.fragments""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1000,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""cloth""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1000,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""lowgradefuel""
  }
]"),

                ("Шприцы Сбор", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 36,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""syringe.medical""
  }
]"),

                ("Локер МВК", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shoes.boots""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pants""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""roadsign.kilt""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hoodie""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.plate.torso""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.facemask""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""tactical.gloves""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rifle.ak""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 8,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""syringe.medical""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 128,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rifle""
  }
]"),

                ("Локер Кофейка", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""shoes.boots""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pants""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""roadsign.kilt""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hoodie""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""jacket""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""coffeecan.helmet""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""smg.thompson""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 8,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""syringe.medical""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 128,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.pistol""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""burlap.gloves""
  }
]"),

                ("Локер Хазик", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hazmatsuit""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 1,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""rifle.semiauto""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 6,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""syringe.medical""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 3,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""bandage""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 64,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""ammo.rifle""
  }
]"),

                ("Автоплавка 1х", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 12,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""sulfur.ore""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 10,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.ore""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 8,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hq.metal.ore""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 8,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""crude.oil""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 25,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""wood""
  }
]"),

                ("Автоплавка 2х", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 25,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""sulfur.ore""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 25,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""metal.ore""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 12,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""hq.metal.ore""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 15,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""crude.oil""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 50,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""wood""
  }
]"),

                ("Чаи", @"[
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""oretea.pure""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""oretea""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""scraptea""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""woodtea.advanced""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""radiationremovetea.advanced""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""healingtea.pure""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""healingtea""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""radiationresisttea.pure""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""maxhealthtea.pure""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""radiationresisttea""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""woodtea.pure""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""maxhealthtea""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""scraptea.advanced""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""woodtea""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""oretea.advanced""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""radiationresisttea.advanced""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""maxhealthtea.advanced""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""radiationremovetea""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""radiationremovetea.pure""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""healingtea.advanced""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 0,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""scraptea.pure""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 60,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""pumpkin""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 60,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""potato""
  },
  {
    ""TargetCategory"": null,
    ""MaxAmountInOutput"": 2,
    ""BufferAmount"": 0,
    ""MinAmountInInput"": 0,
    ""IsBlueprint"": false,
    ""BufferTransferRemaining"": 0,
    ""TargetItemName"": ""waterjug""
  }
]"),
};

            int buttonWidth = 130;
            int buttonHeight = 50;
            int padding = 10;

            for (int i = 0; i < buttonCategories.Length; i++)
            {
                var (buttonText, dataToCopy) = buttonCategories[i];
                Button button = CreateButton(
                    new Point(5 + (i % 6) * (buttonWidth + padding), 460 + (i / 6) * (buttonHeight + padding)),
                    buttonWidth, buttonHeight, buttonText, dataToCopy
                );
                this.Controls.Add(button);
            }
        }

        private Button CreateButton(Point location, int width, int height, string buttonText, string dataToCopy)
        {
            Button button = new Button
            {
                Size = new Size(width, height),
                Location = location,
                Text = buttonText,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightGray,
                Cursor = Cursors.Hand,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Tag = dataToCopy
            };

            button.FlatAppearance.BorderSize = 0;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Click += async (sender, e) => await Button_ClickAsync(button);

            return button;
        }

        private async Task Button_ClickAsync(Button button)
        {
            string dataToCopy = button.Tag?.ToString() ?? string.Empty;

            try
            {
                Clipboard.SetText(dataToCopy);
                button.BackColor = Color.Green;
                await Task.Delay(1500);
                button.BackColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось скопировать текст: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}