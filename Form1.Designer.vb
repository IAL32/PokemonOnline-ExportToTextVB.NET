<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_Pokemon = New System.Windows.Forms.Button()
        Me.lst_Pokemon = New System.Windows.Forms.ListBox()
        Me.rd_Male = New System.Windows.Forms.RadioButton()
        Me.rd_Female = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_SearchText = New System.Windows.Forms.TextBox()
        Me.cmb_Trait = New System.Windows.Forms.ComboBox()
        Me.cmb_Move4 = New System.Windows.Forms.ComboBox()
        Me.cmb_Move3 = New System.Windows.Forms.ComboBox()
        Me.cmb_Move2 = New System.Windows.Forms.ComboBox()
        Me.cmb_Move1 = New System.Windows.Forms.ComboBox()
        Me.cmb_Forms = New System.Windows.Forms.ComboBox()
        Me.lst_Numbers = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btn_Export = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmb_Items = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nup_EVSpd = New System.Windows.Forms.NumericUpDown()
        Me.nup_EVSDef = New System.Windows.Forms.NumericUpDown()
        Me.nup_EVSAtk = New System.Windows.Forms.NumericUpDown()
        Me.nup_EVDef = New System.Windows.Forms.NumericUpDown()
        Me.nup_EVAtk = New System.Windows.Forms.NumericUpDown()
        Me.nup_EVHP = New System.Windows.Forms.NumericUpDown()
        Me.cmb_Nature = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.nup_EVSpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_EVSDef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_EVSAtk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_EVDef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_EVAtk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_EVHP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Pokemon
        '
        Me.btn_Pokemon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Pokemon.Location = New System.Drawing.Point(12, 71)
        Me.btn_Pokemon.Name = "btn_Pokemon"
        Me.btn_Pokemon.Size = New System.Drawing.Size(96, 96)
        Me.btn_Pokemon.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_Pokemon, "Pokémon Image")
        Me.btn_Pokemon.UseVisualStyleBackColor = True
        '
        'lst_Pokemon
        '
        Me.lst_Pokemon.FormattingEnabled = True
        Me.lst_Pokemon.Items.AddRange(New Object() {"----------", "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran F", "Nidorina", "Nidoqueen", "Nidoran M", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw", "Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat", "Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep", "Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff", "Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking", "Misdreavus", "Unown", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull", "Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo", "Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom", "Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid", "Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia", "Ho-oh", "Celebi", "Treecko", "Grovyle", "Sceptile", "Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone", "Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf", "Shiftry", "Taillow", "Swellow", "Wingull", "Pelipper", "Ralts", "Kirlia", "Gardevoir", "Surskit", "Masquerain", "Shroomish", "Breloom", "Slakoth", "Vigoroth", "Slaking", "Nincada", "Ninjask", "Shedinja", "Whismur", "Loudred", "Exploud", "Makuhita", "Hariyama", "Azurill", "Nosepass", "Skitty", "Delcatty", "Sableye", "Mawile", "Aron", "Lairon", "Aggron", "Meditite", "Medicham", "Electrike", "Manectric", "Plusle", "Minun", "Volbeat", "Illumise", "Roselia", "Gulpin", "Swalot", "Carvanha", "Sharpedo", "Wailmer", "Wailord", "Numel", "Camerupt", "Torkoal", "Spoink", "Grumpig", "Spinda", "Trapinch", "Vibrava", "Flygon", "Cacnea", "Cacturne", "Swablu", "Altaria", "Zangoose", "Seviper", "Lunatone", "Solrock", "Barboach", "Whiscash", "Corphish", "Crawdaunt", "Baltoy", "Claydol", "Lileep", "Cradily", "Anorith", "Armaldo", "Feebas", "Milotic", "Castform", "Kecleon", "Shuppet", "Banette", "Duskull", "Dusclops", "Tropius", "Chimecho", "Absol", "Wynaut", "Snorunt", "Glalie", "Spheal", "Sealeo", "Walrein", "Clamperl", "Huntail", "Gorebyss", "Relicanth", "Luvdisc", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang", "Metagross", "Regirock", "Regice", "Registeel", "Latias", "Latios", "Kyogre", "Groudon", "Rayquaza", "Jirachi", "Deoxys", "Turtwig", "Grotle", "Torterra", "Chimchar", "Monferno", "Infernape", "Piplup", "Prinplup", "Empoleon", "Starly", "Staravia", "Staraptor", "Bidoof", "Bibarel", "Kricketot", "Kricketune", "Shinx", "Luxio", "Luxray", "Budew", "Roserade", "Cranidos", "Rampardos", "Shieldon", "Bastiodon", "Burmy", "Wormadam", "Mothim", "Combee", "Vespiquen", "Pachirisu", "Buizel", "Floatzel", "Cherubi", "Cherrim", "Shellos", "Gastrodon", "Ambipom", "Drifloon", "Drifblim", "Buneary", "Lopunny", "Mismagius", "Honchkrow", "Glameow", "Purugly", "Chingling", "Stunky", "Skuntank", "Bronzor", "Bronzong", "Bonsly", "Mime Jr.", "Happiny", "Chatot", "Spiritomb", "Gible", "Gabite", "Garchomp", "Munchlax", "Riolu", "Lucario", "Hippopotas", "Hippowdon", "Skorupi", "Drapion", "Croagunk", "Toxicroak", "Carnivine", "Finneon", "Lumineon", "Mantyke", "Snover", "Abomasnow", "Weavile", "Magnezone", "Lickilicky", "Rhyperior", "Tangrowth", "Electivire", "Magmortar", "Togekiss", "Yanmega", "Leafeon", "Glaceon", "Gliscor", "Mamoswine", "Porygon-Z", "Gallade", "Probopass", "Dusknoir", "Froslass", "Rotom", "Uxie", "Mesprit", "Azelf", "Dialga", "Palkia", "Heatran", "Regigigas", "Giratina", "Cresselia", "Phione", "Manaphy", "Darkrai", "Shaymin", "Arceus", "Victini", "Snivy", "Servine", "Serperior", "Tepig", "Pignite", "Emboar", "Oshawott", "Dewott", "Samurott", "Patrat", "Watchog", "Lillipup", "Herdier", "Stoutland", "Purrloin", "Liepard", "Pansage", "Simisage", "Pansear", "Simisear", "Panpour", "Simipour", "Munna", "Musharna", "Pidove", "Tranquill", "Unfezant", "Blitzle", "Zebstrika", "Roggenrola", "Boldore", "Gigalith", "Woobat", "Swoobat", "Drilbur", "Excadrill", "Audino", "Timburr", "Gurdurr", "Conkeldurr", "Tympole", "Palpitoad", "Seismitoad", "Throh", "Sawk", "Sewaddle", "Swadloon", "Leavanny", "Venipede", "Whirlipede", "Scolipede", "Cottonee", "Whimsicott", "Petilil", "Lilligant", "Basculin", "Sandile", "Krokorok", "Krookodile", "Darumaka", "Darmanitan", "Maractus", "Dwebble", "Crustle", "Scraggy", "Scrafty", "Sigilyph", "Yamask", "Cofagrigus", "Tirtouga", "Carracosta", "Archen", "Archeops", "Trubbish", "Garbodor", "Zorua", "Zoroark", "Minccino", "Cinccino", "Gothita", "Gothorita", "Gothitelle", "Solosis", "Duosion", "Reuniclus", "Ducklett", "Swanna", "Vanillite", "Vanillish", "Vanilluxe", "Deerling", "Sawsbuck", "Emolga", "Karrablast", "Escavalier", "Foongus", "Amoonguss", "Frillish", "Jellicent", "Alomomola", "Joltik", "Galvantula", "Ferroseed", "Ferrothorn", "Klink", "Klang", "Klinklang", "Tynamo", "Eelektrik", "Eelektross", "Elgyem", "Beheeyem", "Litwick", "Lampent", "Chandelure", "Axew", "Fraxure", "Haxorus", "Cubchoo", "Beartic", "Cryogonal", "Shelmet", "Accelgor", "Stunfisk", "Mienfoo", "Mienshao", "Druddigon", "Golett", "Golurk", "Pawniard", "Bisharp", "Bouffalant", "Rufflet", "Braviary", "Vullaby", "Mandibuzz", "Heatmor", "Durant", "Deino", "Zweilous", "Hydreigon", "Larvesta", "Volcarona", "Cobalion", "Terrakion", "Virizion", "Tornadus", "Thundurus", "Reshiram", "Zekrom", "Landorus", "Kyurem", "Keldeo", "Meloetta", "Genesect"})
        Me.lst_Pokemon.Location = New System.Drawing.Point(165, 33)
        Me.lst_Pokemon.Name = "lst_Pokemon"
        Me.lst_Pokemon.Size = New System.Drawing.Size(140, 134)
        Me.lst_Pokemon.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lst_Pokemon, "Select the pokémon by Here.")
        '
        'rd_Male
        '
        Me.rd_Male.AutoSize = True
        Me.rd_Male.Location = New System.Drawing.Point(257, 4)
        Me.rd_Male.Name = "rd_Male"
        Me.rd_Male.Size = New System.Drawing.Size(48, 17)
        Me.rd_Male.TabIndex = 3
        Me.rd_Male.TabStop = True
        Me.rd_Male.Text = "Male"
        Me.ToolTip1.SetToolTip(Me.rd_Male, "Check male if the pokémon is male," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "female if female.")
        Me.rd_Male.UseVisualStyleBackColor = True
        '
        'rd_Female
        '
        Me.rd_Female.AutoSize = True
        Me.rd_Female.Location = New System.Drawing.Point(257, 21)
        Me.rd_Female.Name = "rd_Female"
        Me.rd_Female.Size = New System.Drawing.Size(59, 17)
        Me.rd_Female.TabIndex = 4
        Me.rd_Female.TabStop = True
        Me.rd_Female.Text = "Female"
        Me.ToolTip1.SetToolTip(Me.rd_Female, "Check male if the pokémon is male," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "female if female.")
        Me.rd_Female.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Information"
        '
        'txt_SearchText
        '
        Me.txt_SearchText.Location = New System.Drawing.Point(114, 7)
        Me.txt_SearchText.Name = "txt_SearchText"
        Me.txt_SearchText.Size = New System.Drawing.Size(191, 20)
        Me.txt_SearchText.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txt_SearchText, "Search by Number")
        '
        'cmb_Trait
        '
        Me.cmb_Trait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Trait.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_Trait.FormattingEnabled = True
        Me.cmb_Trait.Items.AddRange(New Object() {"Stench", "Drizzle", "Speed Boost", "Battle Armor", "Sturdy", "Damp", "Limber", "Sand Veil", "Static", "Volt Absorb", "Water Absorb", "Oblivious", "Cloud Nine", "Compoundeyes", "Insomnia", "Color Change", "Immunity", "Flash Fire", "Shield Dust", "Own Tempo", "Suction Cups", "Intimidate", "Shadow Tag", "Rough Skin", "Wonder Guard", "Levitate", "Effect Spore", "Synchronize", "Clear Body", "Natural Cure", "Lightningrod", "Serene Grace", "Swift Swim", "Chlorophyll", "Illuminate", "Trace", "Huge Power", "Poison Point", "Inner Focus", "Magma Armor", "Water Veil", "Magnet Pull", "Soundproof", "Rain Dish", "Sand Stream", "Pressure", "Thick Fat", "Early Bird", "Flame Body", "Run Away", "Keen Eye", "Hyper Cutter", "Pickup", "Truant", "Hustle", "Cute Charm", "Plus", "Minus", "Forecast", "Sticky Hold", "Shed Skin", "Guts", "Marvel Scale", "Liquid Ooze", "Overgrow", "Blaze", "Torrent", "Swarm", "Rock Head", "Drought", "Arena Trap", "Vital Spirit", "White Smoke", "Pure Power", "Shell Armor", "Air Lock", "Tangled Feet", "Motor Drive", "Rivalry", "Steadfast", "Snow Cloak", "Gluttony", "Anger Point", "Unburden", "Heatproof", "Simple", "Dry Skin", "Download", "Iron Fist", "Poison Heal", "Adaptability", "Skill Link", "Hydration", "Solar Power", "Quick Feet", "Normalize", "Sniper", "Magic Guard", "No Guard", "Stall", "Technician", "Leaf Guard", "Klutz", "Mold Breaker", "Super Luck", "Aftermath", "Anticipation", "Forewarn", "Unaware", "Tinted Lens", "Filter", "Slow Start", "Scrappy", "Storm Drain", "Ice Body", "Solid Rock", "Snow Warning", "Honey Gather", "Frisk", "Reckless", "Multitype", "Flower Gift", "Bad Dreams", "Pickpocket", "Sheer Force", "Contrary", "Unnerve", "Defiant", "Defeatist", "Cursed Body", "Healer", "Friend Guard", "Weak Armor", "Heavy Metal", "Light Metal", "Multiscale", "Toxic Boost", "Flare Boost", "Harvest", "Telepathy", "Moody", "Overcoat", "Poison Touch", "Regenerator", "Big Pecks", "Sand Rush", "Wonder Skin", "Analytic", "Illusion", "Imposter", "Infiltrator", "Mummy", "Moxie", "Justified", "Rattled", "Magic Bounce", "Sap Sipper", "Prankster", "Sand Force", "Iron Barbs", "Zen Mode", "Victory Star", "Turboblaze", "Teravolt"})
        Me.cmb_Trait.Location = New System.Drawing.Point(3, 74)
        Me.cmb_Trait.Name = "cmb_Trait"
        Me.cmb_Trait.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Trait.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.cmb_Trait, "Ability")
        '
        'cmb_Move4
        '
        Me.cmb_Move4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Move4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_Move4.FormattingEnabled = True
        Me.cmb_Move4.Items.AddRange(New Object() {"---", "Absorb", "Acid", "Acid Armor", "Acid Spray", "Acrobatics", "Acupressure", "Aerial Ace", "Aeroblast", "After You", "Agility", "Air Cutter", "Air Slash", "Ally Switch", "Amnesia", "AncientPower", "Aqua Jet", "Aqua Ring", "Aqua Tail", "Arm Thrust", "Aromatherapy", "Assist", "Assurance", "Astonish", "Attack Order", "Attract", "Aura Sphere", "Aurora Beam", "Autotomize", "Avalanche", "Barrage", "Barrier", "Baton Pass", "Beat Up", "Belly Drum", "Bestow", "Bide", "Bind", "Bite", "Blast Burn", "Blaze Kick", "Blizzard", "Block", "Blue Flare", "Body Slam", "Bolt Strike", "Bone Club", "Bone Rush", "Bonemerang", "Bounce", "Brave Bird", "Brick Break", "Brine", "Bubble", "BubbleBeam", "Bug Bite", "Bug Buzz", "Bulk Up", "Bulldoze", "Bullet Punch", "Bullet Seed", "Calm Mind", "Camouflage", "Captivate", "Charge", "Charge Beam", "Charm", "Chatter", "Chip Away", "Circle Throw", "Clamp", "Clear Smog", "Close Combat", "Coil", "Comet Punch", "Confuse Ray", "Confusion", "Constrict", "Conversion", "Conversion 2", "Copycat", "Cosmic Power", "Cotton Guard", "Cotton Spore", "Counter", "Covet", "Crabhammer", "Cross Chop", "Cross Poison", "Crunch", "Crush Claw", "Crush Grip", "Curse", "Cut", "Dark Pulse", "Dark Void", "Defend Order", "Defense Curl", "Defog", "Destiny Bond", "Detect", "Dig", "Disable", "Discharge", "Dive", "Dizzy Punch", "Doom Desire", "Double-Edge", "Double Hit", "Double Kick", "Double Team", "DoubleSlap", "Draco Meteor", "Dragon Claw", "Dragon Dance", "Dragon Pulse", "Dragon Rage", "Dragon Rush", "Dragon Tail", "DragonBreath", "Drain Punch", "Dream Eater", "Drill Peck", "Drill Run", "Dual Chop", "DynamicPunch", "Earth Power", "Earthquake", "Echoed Voice", "Egg Bomb", "Electro Ball", "Electroweb", "Embargo", "Ember", "Encore", "Endeavor", "Endure", "Energy Ball", "Entrainment", "Eruption", "Explosion", "Extrasensory", "ExtremeSpeed", "Facade", "Faint Attack", "Fake Out", "Fake Tears", "False Swipe", "FeatherDance", "Feint", "Fiery Dance", "Final Gambit", "Fire Blast", "Fire Fang", "Fire Pledge", "Fire Punch", "Fire Spin", "Fissure", "Flail", "Flame Burst", "Flame Charge", "Flame Wheel", "Flamethrower", "Flare Blitz", "Flash", "Flash Cannon", "Flatter", "Fling", "Fly", "Focus Blast", "Focus Energy", "Focus Punch", "Follow Me", "Force Palm", "Foresight", "Foul Play", "Freeze Shock", "Frenzy Plant", "Frost Breath", "Frustration", "Fury Attack", "Fury Cutter", "Fury Swipes", "Fusion Bolt", "Fusion Flare", "Future Sight", "Gastro Acid", "Gear Grind", "Giga Drain", "Giga Impact", "Glaciate", "Glare", "Grass Knot", "Grass Pledge", "GrassWhistle", "Gravity", "Growl", "Growth", "Grudge", "Guard Split", "Guard Swap", "Guillotine", "Gunk Shot", "Gust", "Gyro Ball", "Hail", "Hammer Arm", "Harden", "Haze", "Head Charge", "Head Smash", "Headbutt", "Heal Bell", "Heal Block", "Heal Order", "Heal Pulse", "Healing Wish", "Heart Stamp", "Heart Swap", "Heat Crash", "Heat Wave", "Heavy Slam", "Helping Hand", "Hex", "Hi Jump Kick", "Hidden Power", "Hone Claws", "Horn Attack", "Horn Drill", "Horn Leech", "Howl", "Hurricane", "Hydro Cannon", "Hydro Pump", "Hyper Beam", "Hyper Fang", "Hyper Voice", "Hypnosis", "Ice Ball", "Ice Beam", "Ice Burn", "Ice Fang", "Ice Punch", "Ice Shard", "Icicle Crash", "Icicle Spear", "Icy Wind", "Imprison", "Incinerate", "Inferno", "Ingrain", "Iron Defense", "Iron Head", "Iron Tail", "Judgment", "Jump Kick", "Karate Chop", "Kinesis", "Knock Off", "Last Resort", "Lava Plume", "Leaf Blade", "Leaf Storm", "Leaf Tornado", "Leech Life", "Leech Seed", "Leer", "Lick", "Light Screen", "Lock-On", "Lovely Kiss", "Low Kick", "Low Sweep", "Lucky Chant", "Lunar Dance", "Luster Purge", "Mach Punch", "Magic Coat", "Magic Room", "Magical Leaf", "Magma Storm", "Magnet Bomb", "Magnet Rise", "Magnitude", "Me First", "Mean Look", "Meditate", "Mega Drain", "Mega Kick", "Mega Punch", "Megahorn", "Memento", "Metal Burst", "Metal Claw", "Metal Sound", "Meteor Mash", "Metronome", "Milk Drink", "Mimic", "Mind Reader", "Minimize", "Miracle Eye", "Mirror Coat", "Mirror Move", "Mirror Shot", "Mist", "Mist Ball", "Moonlight", "Morning Sun", "Mud-Slap", "Mud Bomb", "Mud Shot", "Mud Sport", "Muddy Water", "Nasty Plot", "Natural Gift", "Nature Power", "Needle Arm", "Night Daze", "Night Shade", "Night Slash", "Nightmare", "Octazooka", "Odor Sleuth", "Ominous Wind", "Outrage", "Overheat", "Pain Split", "Pay Day", "Payback", "Peck", "Perish Song", "Petal Dance", "Pin Missile", "Pluck", "Poison Fang", "Poison Gas", "Poison Jab", "Poison Sting", "Poison Tail", "PoisonPowder", "Pound", "Powder Snow", "Power Gem", "Power Split", "Power Swap", "Power Trick", "Power Whip", "Present", "Protect", "Psybeam", "Psych Up", "Psychic", "Psycho Boost", "Psycho Cut", "Psycho Shift", "Psyshock", "Psystrike", "Psywave", "Punishment", "Pursuit", "Quash", "Quick Attack", "Quick Guard", "Quiver Dance", "Rage", "Rage Powder", "Rain Dance", "Rapid Spin", "Razor Leaf", "Razor Shell", "Razor Wind", "Recover", "Recycle", "Reflect", "Reflect Type", "Refresh", "Relic Song", "Rest", "Retaliate", "Return", "Revenge", "Reversal", "Roar", "Roar of Time", "Rock Blast", "Rock Climb", "Rock Polish", "Rock Slide", "Rock Smash", "Rock Throw", "Rock Tomb", "Rock Wrecker", "Role Play", "Rolling Kick", "Rollout", "Roost", "Round", "Sacred Fire", "Sacred Sword", "Safeguard", "Sand-Attack", "Sand Tomb", "Sandstorm", "Scald", "Scary Face", "Scratch", "Screech", "Searing Shot", "Secret Power", "Secret Sword", "Seed Bomb", "Seed Flare", "Seismic Toss", "Selfdestruct", "Shadow Ball", "Shadow Claw", "Shadow Force", "Shadow Punch", "Shadow Sneak", "Sharpen", "Sheer Cold", "Shell Smash", "Shift Gear", "Shock Wave", "Signal Beam", "Silver Wind", "Simple Beam", "Sing", "Sketch", "Skill Swap", "Skull Bash", "Sky Attack", "Sky Drop", "Sky Uppercut", "Slack Off", "Slam", "Slash", "Sleep Powder", "Sleep Talk", "Sludge", "Sludge Bomb", "Sludge Wave", "Smack Down", "SmellingSalt", "Smog", "SmokeScreen", "Snarl", "Snatch", "Snore", "Soak", "Softboiled", "SolarBeam", "SonicBoom", "Spacial Rend", "Spark", "Spider Web", "Spike Cannon", "Spikes", "Spit Up", "Spite", "Splash", "Spore", "Stealth Rock", "Steamroller", "Steel Wing", "Stockpile", "Stomp", "Stone Edge", "Stored Power", "Storm Throw", "Strength", "String Shot", "Struggle", "Struggle Bug", "Stun Spore", "Submission", "Substitute", "Sucker Punch", "Sunny Day", "Super Fang", "Superpower", "Supersonic", "Surf", "Swagger", "Swallow", "Sweet Kiss", "Sweet Scent", "Swift", "Switcheroo", "Swords Dance", "Synchronoise", "Synthesis", "Tackle", "Tail Glow", "Tail Slap", "Tail Whip", "Tailwind", "Take Down", "Taunt", "Techno Blast", "Teeter Dance", "Telekinesis", "Teleport", "Thief", "Thrash", "Thunder", "Thunder Fang", "Thunder Wave", "Thunderbolt", "ThunderPunch", "ThunderShock", "Tickle", "Torment", "Toxic", "Toxic Spikes", "Transform", "Tri Attack", "Trick", "Trick Room", "Triple Kick", "Trump Card", "Twineedle", "Twister", "U-turn", "Uproar", "V-create", "Vacuum Wave", "Venoshock", "ViceGrip", "Vine Whip", "Vital Throw", "Volt Switch", "Volt Tackle", "Wake-Up Slap", "Water Gun", "Water Pledge", "Water Pulse", "Water Sport", "Water Spout", "Waterfall", "Weather Ball", "Whirlpool", "Whirlwind", "Wide Guard", "Wild Charge", "Will-O-Wisp", "Wing Attack", "Wish", "Withdraw", "Wonder Room", "Wood Hammer", "Work Up", "Worry Seed", "Wrap", "Wring Out", "X-Scissor", "Yawn", "Zap Cannon", "Zen Headbutt"})
        Me.cmb_Move4.Location = New System.Drawing.Point(130, 25)
        Me.cmb_Move4.Name = "cmb_Move4"
        Me.cmb_Move4.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Move4.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.cmb_Move4, "Moves that the pokémon can have." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note that Pokémon Online will check if" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the pok" & _
                "émon will really have the selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "move.")
        '
        'cmb_Move3
        '
        Me.cmb_Move3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Move3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_Move3.FormattingEnabled = True
        Me.cmb_Move3.Items.AddRange(New Object() {"---", "Absorb", "Acid", "Acid Armor", "Acid Spray", "Acrobatics", "Acupressure", "Aerial Ace", "Aeroblast", "After You", "Agility", "Air Cutter", "Air Slash", "Ally Switch", "Amnesia", "AncientPower", "Aqua Jet", "Aqua Ring", "Aqua Tail", "Arm Thrust", "Aromatherapy", "Assist", "Assurance", "Astonish", "Attack Order", "Attract", "Aura Sphere", "Aurora Beam", "Autotomize", "Avalanche", "Barrage", "Barrier", "Baton Pass", "Beat Up", "Belly Drum", "Bestow", "Bide", "Bind", "Bite", "Blast Burn", "Blaze Kick", "Blizzard", "Block", "Blue Flare", "Body Slam", "Bolt Strike", "Bone Club", "Bone Rush", "Bonemerang", "Bounce", "Brave Bird", "Brick Break", "Brine", "Bubble", "BubbleBeam", "Bug Bite", "Bug Buzz", "Bulk Up", "Bulldoze", "Bullet Punch", "Bullet Seed", "Calm Mind", "Camouflage", "Captivate", "Charge", "Charge Beam", "Charm", "Chatter", "Chip Away", "Circle Throw", "Clamp", "Clear Smog", "Close Combat", "Coil", "Comet Punch", "Confuse Ray", "Confusion", "Constrict", "Conversion", "Conversion 2", "Copycat", "Cosmic Power", "Cotton Guard", "Cotton Spore", "Counter", "Covet", "Crabhammer", "Cross Chop", "Cross Poison", "Crunch", "Crush Claw", "Crush Grip", "Curse", "Cut", "Dark Pulse", "Dark Void", "Defend Order", "Defense Curl", "Defog", "Destiny Bond", "Detect", "Dig", "Disable", "Discharge", "Dive", "Dizzy Punch", "Doom Desire", "Double-Edge", "Double Hit", "Double Kick", "Double Team", "DoubleSlap", "Draco Meteor", "Dragon Claw", "Dragon Dance", "Dragon Pulse", "Dragon Rage", "Dragon Rush", "Dragon Tail", "DragonBreath", "Drain Punch", "Dream Eater", "Drill Peck", "Drill Run", "Dual Chop", "DynamicPunch", "Earth Power", "Earthquake", "Echoed Voice", "Egg Bomb", "Electro Ball", "Electroweb", "Embargo", "Ember", "Encore", "Endeavor", "Endure", "Energy Ball", "Entrainment", "Eruption", "Explosion", "Extrasensory", "ExtremeSpeed", "Facade", "Faint Attack", "Fake Out", "Fake Tears", "False Swipe", "FeatherDance", "Feint", "Fiery Dance", "Final Gambit", "Fire Blast", "Fire Fang", "Fire Pledge", "Fire Punch", "Fire Spin", "Fissure", "Flail", "Flame Burst", "Flame Charge", "Flame Wheel", "Flamethrower", "Flare Blitz", "Flash", "Flash Cannon", "Flatter", "Fling", "Fly", "Focus Blast", "Focus Energy", "Focus Punch", "Follow Me", "Force Palm", "Foresight", "Foul Play", "Freeze Shock", "Frenzy Plant", "Frost Breath", "Frustration", "Fury Attack", "Fury Cutter", "Fury Swipes", "Fusion Bolt", "Fusion Flare", "Future Sight", "Gastro Acid", "Gear Grind", "Giga Drain", "Giga Impact", "Glaciate", "Glare", "Grass Knot", "Grass Pledge", "GrassWhistle", "Gravity", "Growl", "Growth", "Grudge", "Guard Split", "Guard Swap", "Guillotine", "Gunk Shot", "Gust", "Gyro Ball", "Hail", "Hammer Arm", "Harden", "Haze", "Head Charge", "Head Smash", "Headbutt", "Heal Bell", "Heal Block", "Heal Order", "Heal Pulse", "Healing Wish", "Heart Stamp", "Heart Swap", "Heat Crash", "Heat Wave", "Heavy Slam", "Helping Hand", "Hex", "Hi Jump Kick", "Hidden Power", "Hone Claws", "Horn Attack", "Horn Drill", "Horn Leech", "Howl", "Hurricane", "Hydro Cannon", "Hydro Pump", "Hyper Beam", "Hyper Fang", "Hyper Voice", "Hypnosis", "Ice Ball", "Ice Beam", "Ice Burn", "Ice Fang", "Ice Punch", "Ice Shard", "Icicle Crash", "Icicle Spear", "Icy Wind", "Imprison", "Incinerate", "Inferno", "Ingrain", "Iron Defense", "Iron Head", "Iron Tail", "Judgment", "Jump Kick", "Karate Chop", "Kinesis", "Knock Off", "Last Resort", "Lava Plume", "Leaf Blade", "Leaf Storm", "Leaf Tornado", "Leech Life", "Leech Seed", "Leer", "Lick", "Light Screen", "Lock-On", "Lovely Kiss", "Low Kick", "Low Sweep", "Lucky Chant", "Lunar Dance", "Luster Purge", "Mach Punch", "Magic Coat", "Magic Room", "Magical Leaf", "Magma Storm", "Magnet Bomb", "Magnet Rise", "Magnitude", "Me First", "Mean Look", "Meditate", "Mega Drain", "Mega Kick", "Mega Punch", "Megahorn", "Memento", "Metal Burst", "Metal Claw", "Metal Sound", "Meteor Mash", "Metronome", "Milk Drink", "Mimic", "Mind Reader", "Minimize", "Miracle Eye", "Mirror Coat", "Mirror Move", "Mirror Shot", "Mist", "Mist Ball", "Moonlight", "Morning Sun", "Mud-Slap", "Mud Bomb", "Mud Shot", "Mud Sport", "Muddy Water", "Nasty Plot", "Natural Gift", "Nature Power", "Needle Arm", "Night Daze", "Night Shade", "Night Slash", "Nightmare", "Octazooka", "Odor Sleuth", "Ominous Wind", "Outrage", "Overheat", "Pain Split", "Pay Day", "Payback", "Peck", "Perish Song", "Petal Dance", "Pin Missile", "Pluck", "Poison Fang", "Poison Gas", "Poison Jab", "Poison Sting", "Poison Tail", "PoisonPowder", "Pound", "Powder Snow", "Power Gem", "Power Split", "Power Swap", "Power Trick", "Power Whip", "Present", "Protect", "Psybeam", "Psych Up", "Psychic", "Psycho Boost", "Psycho Cut", "Psycho Shift", "Psyshock", "Psystrike", "Psywave", "Punishment", "Pursuit", "Quash", "Quick Attack", "Quick Guard", "Quiver Dance", "Rage", "Rage Powder", "Rain Dance", "Rapid Spin", "Razor Leaf", "Razor Shell", "Razor Wind", "Recover", "Recycle", "Reflect", "Reflect Type", "Refresh", "Relic Song", "Rest", "Retaliate", "Return", "Revenge", "Reversal", "Roar", "Roar of Time", "Rock Blast", "Rock Climb", "Rock Polish", "Rock Slide", "Rock Smash", "Rock Throw", "Rock Tomb", "Rock Wrecker", "Role Play", "Rolling Kick", "Rollout", "Roost", "Round", "Sacred Fire", "Sacred Sword", "Safeguard", "Sand-Attack", "Sand Tomb", "Sandstorm", "Scald", "Scary Face", "Scratch", "Screech", "Searing Shot", "Secret Power", "Secret Sword", "Seed Bomb", "Seed Flare", "Seismic Toss", "Selfdestruct", "Shadow Ball", "Shadow Claw", "Shadow Force", "Shadow Punch", "Shadow Sneak", "Sharpen", "Sheer Cold", "Shell Smash", "Shift Gear", "Shock Wave", "Signal Beam", "Silver Wind", "Simple Beam", "Sing", "Sketch", "Skill Swap", "Skull Bash", "Sky Attack", "Sky Drop", "Sky Uppercut", "Slack Off", "Slam", "Slash", "Sleep Powder", "Sleep Talk", "Sludge", "Sludge Bomb", "Sludge Wave", "Smack Down", "SmellingSalt", "Smog", "SmokeScreen", "Snarl", "Snatch", "Snore", "Soak", "Softboiled", "SolarBeam", "SonicBoom", "Spacial Rend", "Spark", "Spider Web", "Spike Cannon", "Spikes", "Spit Up", "Spite", "Splash", "Spore", "Stealth Rock", "Steamroller", "Steel Wing", "Stockpile", "Stomp", "Stone Edge", "Stored Power", "Storm Throw", "Strength", "String Shot", "Struggle", "Struggle Bug", "Stun Spore", "Submission", "Substitute", "Sucker Punch", "Sunny Day", "Super Fang", "Superpower", "Supersonic", "Surf", "Swagger", "Swallow", "Sweet Kiss", "Sweet Scent", "Swift", "Switcheroo", "Swords Dance", "Synchronoise", "Synthesis", "Tackle", "Tail Glow", "Tail Slap", "Tail Whip", "Tailwind", "Take Down", "Taunt", "Techno Blast", "Teeter Dance", "Telekinesis", "Teleport", "Thief", "Thrash", "Thunder", "Thunder Fang", "Thunder Wave", "Thunderbolt", "ThunderPunch", "ThunderShock", "Tickle", "Torment", "Toxic", "Toxic Spikes", "Transform", "Tri Attack", "Trick", "Trick Room", "Triple Kick", "Trump Card", "Twineedle", "Twister", "U-turn", "Uproar", "V-create", "Vacuum Wave", "Venoshock", "ViceGrip", "Vine Whip", "Vital Throw", "Volt Switch", "Volt Tackle", "Wake-Up Slap", "Water Gun", "Water Pledge", "Water Pulse", "Water Sport", "Water Spout", "Waterfall", "Weather Ball", "Whirlpool", "Whirlwind", "Wide Guard", "Wild Charge", "Will-O-Wisp", "Wing Attack", "Wish", "Withdraw", "Wonder Room", "Wood Hammer", "Work Up", "Worry Seed", "Wrap", "Wring Out", "X-Scissor", "Yawn", "Zap Cannon", "Zen Headbutt"})
        Me.cmb_Move3.Location = New System.Drawing.Point(3, 25)
        Me.cmb_Move3.Name = "cmb_Move3"
        Me.cmb_Move3.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Move3.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.cmb_Move3, "Moves that the pokémon can have." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note that Pokémon Online will check if" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the pok" & _
                "émon will really have the selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "move.")
        '
        'cmb_Move2
        '
        Me.cmb_Move2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Move2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_Move2.FormattingEnabled = True
        Me.cmb_Move2.Items.AddRange(New Object() {"---", "Absorb", "Acid", "Acid Armor", "Acid Spray", "Acrobatics", "Acupressure", "Aerial Ace", "Aeroblast", "After You", "Agility", "Air Cutter", "Air Slash", "Ally Switch", "Amnesia", "AncientPower", "Aqua Jet", "Aqua Ring", "Aqua Tail", "Arm Thrust", "Aromatherapy", "Assist", "Assurance", "Astonish", "Attack Order", "Attract", "Aura Sphere", "Aurora Beam", "Autotomize", "Avalanche", "Barrage", "Barrier", "Baton Pass", "Beat Up", "Belly Drum", "Bestow", "Bide", "Bind", "Bite", "Blast Burn", "Blaze Kick", "Blizzard", "Block", "Blue Flare", "Body Slam", "Bolt Strike", "Bone Club", "Bone Rush", "Bonemerang", "Bounce", "Brave Bird", "Brick Break", "Brine", "Bubble", "BubbleBeam", "Bug Bite", "Bug Buzz", "Bulk Up", "Bulldoze", "Bullet Punch", "Bullet Seed", "Calm Mind", "Camouflage", "Captivate", "Charge", "Charge Beam", "Charm", "Chatter", "Chip Away", "Circle Throw", "Clamp", "Clear Smog", "Close Combat", "Coil", "Comet Punch", "Confuse Ray", "Confusion", "Constrict", "Conversion", "Conversion 2", "Copycat", "Cosmic Power", "Cotton Guard", "Cotton Spore", "Counter", "Covet", "Crabhammer", "Cross Chop", "Cross Poison", "Crunch", "Crush Claw", "Crush Grip", "Curse", "Cut", "Dark Pulse", "Dark Void", "Defend Order", "Defense Curl", "Defog", "Destiny Bond", "Detect", "Dig", "Disable", "Discharge", "Dive", "Dizzy Punch", "Doom Desire", "Double-Edge", "Double Hit", "Double Kick", "Double Team", "DoubleSlap", "Draco Meteor", "Dragon Claw", "Dragon Dance", "Dragon Pulse", "Dragon Rage", "Dragon Rush", "Dragon Tail", "DragonBreath", "Drain Punch", "Dream Eater", "Drill Peck", "Drill Run", "Dual Chop", "DynamicPunch", "Earth Power", "Earthquake", "Echoed Voice", "Egg Bomb", "Electro Ball", "Electroweb", "Embargo", "Ember", "Encore", "Endeavor", "Endure", "Energy Ball", "Entrainment", "Eruption", "Explosion", "Extrasensory", "ExtremeSpeed", "Facade", "Faint Attack", "Fake Out", "Fake Tears", "False Swipe", "FeatherDance", "Feint", "Fiery Dance", "Final Gambit", "Fire Blast", "Fire Fang", "Fire Pledge", "Fire Punch", "Fire Spin", "Fissure", "Flail", "Flame Burst", "Flame Charge", "Flame Wheel", "Flamethrower", "Flare Blitz", "Flash", "Flash Cannon", "Flatter", "Fling", "Fly", "Focus Blast", "Focus Energy", "Focus Punch", "Follow Me", "Force Palm", "Foresight", "Foul Play", "Freeze Shock", "Frenzy Plant", "Frost Breath", "Frustration", "Fury Attack", "Fury Cutter", "Fury Swipes", "Fusion Bolt", "Fusion Flare", "Future Sight", "Gastro Acid", "Gear Grind", "Giga Drain", "Giga Impact", "Glaciate", "Glare", "Grass Knot", "Grass Pledge", "GrassWhistle", "Gravity", "Growl", "Growth", "Grudge", "Guard Split", "Guard Swap", "Guillotine", "Gunk Shot", "Gust", "Gyro Ball", "Hail", "Hammer Arm", "Harden", "Haze", "Head Charge", "Head Smash", "Headbutt", "Heal Bell", "Heal Block", "Heal Order", "Heal Pulse", "Healing Wish", "Heart Stamp", "Heart Swap", "Heat Crash", "Heat Wave", "Heavy Slam", "Helping Hand", "Hex", "Hi Jump Kick", "Hidden Power", "Hone Claws", "Horn Attack", "Horn Drill", "Horn Leech", "Howl", "Hurricane", "Hydro Cannon", "Hydro Pump", "Hyper Beam", "Hyper Fang", "Hyper Voice", "Hypnosis", "Ice Ball", "Ice Beam", "Ice Burn", "Ice Fang", "Ice Punch", "Ice Shard", "Icicle Crash", "Icicle Spear", "Icy Wind", "Imprison", "Incinerate", "Inferno", "Ingrain", "Iron Defense", "Iron Head", "Iron Tail", "Judgment", "Jump Kick", "Karate Chop", "Kinesis", "Knock Off", "Last Resort", "Lava Plume", "Leaf Blade", "Leaf Storm", "Leaf Tornado", "Leech Life", "Leech Seed", "Leer", "Lick", "Light Screen", "Lock-On", "Lovely Kiss", "Low Kick", "Low Sweep", "Lucky Chant", "Lunar Dance", "Luster Purge", "Mach Punch", "Magic Coat", "Magic Room", "Magical Leaf", "Magma Storm", "Magnet Bomb", "Magnet Rise", "Magnitude", "Me First", "Mean Look", "Meditate", "Mega Drain", "Mega Kick", "Mega Punch", "Megahorn", "Memento", "Metal Burst", "Metal Claw", "Metal Sound", "Meteor Mash", "Metronome", "Milk Drink", "Mimic", "Mind Reader", "Minimize", "Miracle Eye", "Mirror Coat", "Mirror Move", "Mirror Shot", "Mist", "Mist Ball", "Moonlight", "Morning Sun", "Mud-Slap", "Mud Bomb", "Mud Shot", "Mud Sport", "Muddy Water", "Nasty Plot", "Natural Gift", "Nature Power", "Needle Arm", "Night Daze", "Night Shade", "Night Slash", "Nightmare", "Octazooka", "Odor Sleuth", "Ominous Wind", "Outrage", "Overheat", "Pain Split", "Pay Day", "Payback", "Peck", "Perish Song", "Petal Dance", "Pin Missile", "Pluck", "Poison Fang", "Poison Gas", "Poison Jab", "Poison Sting", "Poison Tail", "PoisonPowder", "Pound", "Powder Snow", "Power Gem", "Power Split", "Power Swap", "Power Trick", "Power Whip", "Present", "Protect", "Psybeam", "Psych Up", "Psychic", "Psycho Boost", "Psycho Cut", "Psycho Shift", "Psyshock", "Psystrike", "Psywave", "Punishment", "Pursuit", "Quash", "Quick Attack", "Quick Guard", "Quiver Dance", "Rage", "Rage Powder", "Rain Dance", "Rapid Spin", "Razor Leaf", "Razor Shell", "Razor Wind", "Recover", "Recycle", "Reflect", "Reflect Type", "Refresh", "Relic Song", "Rest", "Retaliate", "Return", "Revenge", "Reversal", "Roar", "Roar of Time", "Rock Blast", "Rock Climb", "Rock Polish", "Rock Slide", "Rock Smash", "Rock Throw", "Rock Tomb", "Rock Wrecker", "Role Play", "Rolling Kick", "Rollout", "Roost", "Round", "Sacred Fire", "Sacred Sword", "Safeguard", "Sand-Attack", "Sand Tomb", "Sandstorm", "Scald", "Scary Face", "Scratch", "Screech", "Searing Shot", "Secret Power", "Secret Sword", "Seed Bomb", "Seed Flare", "Seismic Toss", "Selfdestruct", "Shadow Ball", "Shadow Claw", "Shadow Force", "Shadow Punch", "Shadow Sneak", "Sharpen", "Sheer Cold", "Shell Smash", "Shift Gear", "Shock Wave", "Signal Beam", "Silver Wind", "Simple Beam", "Sing", "Sketch", "Skill Swap", "Skull Bash", "Sky Attack", "Sky Drop", "Sky Uppercut", "Slack Off", "Slam", "Slash", "Sleep Powder", "Sleep Talk", "Sludge", "Sludge Bomb", "Sludge Wave", "Smack Down", "SmellingSalt", "Smog", "SmokeScreen", "Snarl", "Snatch", "Snore", "Soak", "Softboiled", "SolarBeam", "SonicBoom", "Spacial Rend", "Spark", "Spider Web", "Spike Cannon", "Spikes", "Spit Up", "Spite", "Splash", "Spore", "Stealth Rock", "Steamroller", "Steel Wing", "Stockpile", "Stomp", "Stone Edge", "Stored Power", "Storm Throw", "Strength", "String Shot", "Struggle", "Struggle Bug", "Stun Spore", "Submission", "Substitute", "Sucker Punch", "Sunny Day", "Super Fang", "Superpower", "Supersonic", "Surf", "Swagger", "Swallow", "Sweet Kiss", "Sweet Scent", "Swift", "Switcheroo", "Swords Dance", "Synchronoise", "Synthesis", "Tackle", "Tail Glow", "Tail Slap", "Tail Whip", "Tailwind", "Take Down", "Taunt", "Techno Blast", "Teeter Dance", "Telekinesis", "Teleport", "Thief", "Thrash", "Thunder", "Thunder Fang", "Thunder Wave", "Thunderbolt", "ThunderPunch", "ThunderShock", "Tickle", "Torment", "Toxic", "Toxic Spikes", "Transform", "Tri Attack", "Trick", "Trick Room", "Triple Kick", "Trump Card", "Twineedle", "Twister", "U-turn", "Uproar", "V-create", "Vacuum Wave", "Venoshock", "ViceGrip", "Vine Whip", "Vital Throw", "Volt Switch", "Volt Tackle", "Wake-Up Slap", "Water Gun", "Water Pledge", "Water Pulse", "Water Sport", "Water Spout", "Waterfall", "Weather Ball", "Whirlpool", "Whirlwind", "Wide Guard", "Wild Charge", "Will-O-Wisp", "Wing Attack", "Wish", "Withdraw", "Wonder Room", "Wood Hammer", "Work Up", "Worry Seed", "Wrap", "Wring Out", "X-Scissor", "Yawn", "Zap Cannon", "Zen Headbutt"})
        Me.cmb_Move2.Location = New System.Drawing.Point(130, 3)
        Me.cmb_Move2.Name = "cmb_Move2"
        Me.cmb_Move2.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Move2.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.cmb_Move2, "Moves that the pokémon can have." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note that Pokémon Online will check if" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the pok" & _
                "émon will really have the selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "move.")
        '
        'cmb_Move1
        '
        Me.cmb_Move1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Move1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_Move1.FormattingEnabled = True
        Me.cmb_Move1.Items.AddRange(New Object() {"---", "Absorb", "Acid", "Acid Armor", "Acid Spray", "Acrobatics", "Acupressure", "Aerial Ace", "Aeroblast", "After You", "Agility", "Air Cutter", "Air Slash", "Ally Switch", "Amnesia", "AncientPower", "Aqua Jet", "Aqua Ring", "Aqua Tail", "Arm Thrust", "Aromatherapy", "Assist", "Assurance", "Astonish", "Attack Order", "Attract", "Aura Sphere", "Aurora Beam", "Autotomize", "Avalanche", "Barrage", "Barrier", "Baton Pass", "Beat Up", "Belly Drum", "Bestow", "Bide", "Bind", "Bite", "Blast Burn", "Blaze Kick", "Blizzard", "Block", "Blue Flare", "Body Slam", "Bolt Strike", "Bone Club", "Bone Rush", "Bonemerang", "Bounce", "Brave Bird", "Brick Break", "Brine", "Bubble", "BubbleBeam", "Bug Bite", "Bug Buzz", "Bulk Up", "Bulldoze", "Bullet Punch", "Bullet Seed", "Calm Mind", "Camouflage", "Captivate", "Charge", "Charge Beam", "Charm", "Chatter", "Chip Away", "Circle Throw", "Clamp", "Clear Smog", "Close Combat", "Coil", "Comet Punch", "Confuse Ray", "Confusion", "Constrict", "Conversion", "Conversion 2", "Copycat", "Cosmic Power", "Cotton Guard", "Cotton Spore", "Counter", "Covet", "Crabhammer", "Cross Chop", "Cross Poison", "Crunch", "Crush Claw", "Crush Grip", "Curse", "Cut", "Dark Pulse", "Dark Void", "Defend Order", "Defense Curl", "Defog", "Destiny Bond", "Detect", "Dig", "Disable", "Discharge", "Dive", "Dizzy Punch", "Doom Desire", "Double-Edge", "Double Hit", "Double Kick", "Double Team", "DoubleSlap", "Draco Meteor", "Dragon Claw", "Dragon Dance", "Dragon Pulse", "Dragon Rage", "Dragon Rush", "Dragon Tail", "DragonBreath", "Drain Punch", "Dream Eater", "Drill Peck", "Drill Run", "Dual Chop", "DynamicPunch", "Earth Power", "Earthquake", "Echoed Voice", "Egg Bomb", "Electro Ball", "Electroweb", "Embargo", "Ember", "Encore", "Endeavor", "Endure", "Energy Ball", "Entrainment", "Eruption", "Explosion", "Extrasensory", "ExtremeSpeed", "Facade", "Faint Attack", "Fake Out", "Fake Tears", "False Swipe", "FeatherDance", "Feint", "Fiery Dance", "Final Gambit", "Fire Blast", "Fire Fang", "Fire Pledge", "Fire Punch", "Fire Spin", "Fissure", "Flail", "Flame Burst", "Flame Charge", "Flame Wheel", "Flamethrower", "Flare Blitz", "Flash", "Flash Cannon", "Flatter", "Fling", "Fly", "Focus Blast", "Focus Energy", "Focus Punch", "Follow Me", "Force Palm", "Foresight", "Foul Play", "Freeze Shock", "Frenzy Plant", "Frost Breath", "Frustration", "Fury Attack", "Fury Cutter", "Fury Swipes", "Fusion Bolt", "Fusion Flare", "Future Sight", "Gastro Acid", "Gear Grind", "Giga Drain", "Giga Impact", "Glaciate", "Glare", "Grass Knot", "Grass Pledge", "GrassWhistle", "Gravity", "Growl", "Growth", "Grudge", "Guard Split", "Guard Swap", "Guillotine", "Gunk Shot", "Gust", "Gyro Ball", "Hail", "Hammer Arm", "Harden", "Haze", "Head Charge", "Head Smash", "Headbutt", "Heal Bell", "Heal Block", "Heal Order", "Heal Pulse", "Healing Wish", "Heart Stamp", "Heart Swap", "Heat Crash", "Heat Wave", "Heavy Slam", "Helping Hand", "Hex", "Hi Jump Kick", "Hidden Power", "Hone Claws", "Horn Attack", "Horn Drill", "Horn Leech", "Howl", "Hurricane", "Hydro Cannon", "Hydro Pump", "Hyper Beam", "Hyper Fang", "Hyper Voice", "Hypnosis", "Ice Ball", "Ice Beam", "Ice Burn", "Ice Fang", "Ice Punch", "Ice Shard", "Icicle Crash", "Icicle Spear", "Icy Wind", "Imprison", "Incinerate", "Inferno", "Ingrain", "Iron Defense", "Iron Head", "Iron Tail", "Judgment", "Jump Kick", "Karate Chop", "Kinesis", "Knock Off", "Last Resort", "Lava Plume", "Leaf Blade", "Leaf Storm", "Leaf Tornado", "Leech Life", "Leech Seed", "Leer", "Lick", "Light Screen", "Lock-On", "Lovely Kiss", "Low Kick", "Low Sweep", "Lucky Chant", "Lunar Dance", "Luster Purge", "Mach Punch", "Magic Coat", "Magic Room", "Magical Leaf", "Magma Storm", "Magnet Bomb", "Magnet Rise", "Magnitude", "Me First", "Mean Look", "Meditate", "Mega Drain", "Mega Kick", "Mega Punch", "Megahorn", "Memento", "Metal Burst", "Metal Claw", "Metal Sound", "Meteor Mash", "Metronome", "Milk Drink", "Mimic", "Mind Reader", "Minimize", "Miracle Eye", "Mirror Coat", "Mirror Move", "Mirror Shot", "Mist", "Mist Ball", "Moonlight", "Morning Sun", "Mud-Slap", "Mud Bomb", "Mud Shot", "Mud Sport", "Muddy Water", "Nasty Plot", "Natural Gift", "Nature Power", "Needle Arm", "Night Daze", "Night Shade", "Night Slash", "Nightmare", "Octazooka", "Odor Sleuth", "Ominous Wind", "Outrage", "Overheat", "Pain Split", "Pay Day", "Payback", "Peck", "Perish Song", "Petal Dance", "Pin Missile", "Pluck", "Poison Fang", "Poison Gas", "Poison Jab", "Poison Sting", "Poison Tail", "PoisonPowder", "Pound", "Powder Snow", "Power Gem", "Power Split", "Power Swap", "Power Trick", "Power Whip", "Present", "Protect", "Psybeam", "Psych Up", "Psychic", "Psycho Boost", "Psycho Cut", "Psycho Shift", "Psyshock", "Psystrike", "Psywave", "Punishment", "Pursuit", "Quash", "Quick Attack", "Quick Guard", "Quiver Dance", "Rage", "Rage Powder", "Rain Dance", "Rapid Spin", "Razor Leaf", "Razor Shell", "Razor Wind", "Recover", "Recycle", "Reflect", "Reflect Type", "Refresh", "Relic Song", "Rest", "Retaliate", "Return", "Revenge", "Reversal", "Roar", "Roar of Time", "Rock Blast", "Rock Climb", "Rock Polish", "Rock Slide", "Rock Smash", "Rock Throw", "Rock Tomb", "Rock Wrecker", "Role Play", "Rolling Kick", "Rollout", "Roost", "Round", "Sacred Fire", "Sacred Sword", "Safeguard", "Sand-Attack", "Sand Tomb", "Sandstorm", "Scald", "Scary Face", "Scratch", "Screech", "Searing Shot", "Secret Power", "Secret Sword", "Seed Bomb", "Seed Flare", "Seismic Toss", "Selfdestruct", "Shadow Ball", "Shadow Claw", "Shadow Force", "Shadow Punch", "Shadow Sneak", "Sharpen", "Sheer Cold", "Shell Smash", "Shift Gear", "Shock Wave", "Signal Beam", "Silver Wind", "Simple Beam", "Sing", "Sketch", "Skill Swap", "Skull Bash", "Sky Attack", "Sky Drop", "Sky Uppercut", "Slack Off", "Slam", "Slash", "Sleep Powder", "Sleep Talk", "Sludge", "Sludge Bomb", "Sludge Wave", "Smack Down", "SmellingSalt", "Smog", "SmokeScreen", "Snarl", "Snatch", "Snore", "Soak", "Softboiled", "SolarBeam", "SonicBoom", "Spacial Rend", "Spark", "Spider Web", "Spike Cannon", "Spikes", "Spit Up", "Spite", "Splash", "Spore", "Stealth Rock", "Steamroller", "Steel Wing", "Stockpile", "Stomp", "Stone Edge", "Stored Power", "Storm Throw", "Strength", "String Shot", "Struggle", "Struggle Bug", "Stun Spore", "Submission", "Substitute", "Sucker Punch", "Sunny Day", "Super Fang", "Superpower", "Supersonic", "Surf", "Swagger", "Swallow", "Sweet Kiss", "Sweet Scent", "Swift", "Switcheroo", "Swords Dance", "Synchronoise", "Synthesis", "Tackle", "Tail Glow", "Tail Slap", "Tail Whip", "Tailwind", "Take Down", "Taunt", "Techno Blast", "Teeter Dance", "Telekinesis", "Teleport", "Thief", "Thrash", "Thunder", "Thunder Fang", "Thunder Wave", "Thunderbolt", "ThunderPunch", "ThunderShock", "Tickle", "Torment", "Toxic", "Toxic Spikes", "Transform", "Tri Attack", "Trick", "Trick Room", "Triple Kick", "Trump Card", "Twineedle", "Twister", "U-turn", "Uproar", "V-create", "Vacuum Wave", "Venoshock", "ViceGrip", "Vine Whip", "Vital Throw", "Volt Switch", "Volt Tackle", "Wake-Up Slap", "Water Gun", "Water Pledge", "Water Pulse", "Water Sport", "Water Spout", "Waterfall", "Weather Ball", "Whirlpool", "Whirlwind", "Wide Guard", "Wild Charge", "Will-O-Wisp", "Wing Attack", "Wish", "Withdraw", "Wonder Room", "Wood Hammer", "Work Up", "Worry Seed", "Wrap", "Wring Out", "X-Scissor", "Yawn", "Zap Cannon", "Zen Headbutt"})
        Me.cmb_Move1.Location = New System.Drawing.Point(3, 3)
        Me.cmb_Move1.Name = "cmb_Move1"
        Me.cmb_Move1.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Move1.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.cmb_Move1, "Moves that the pokémon can have." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note that Pokémon Online will check if" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the pok" & _
                "émon will really have the selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "move.")
        '
        'cmb_Forms
        '
        Me.cmb_Forms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Forms.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_Forms.FormattingEnabled = True
        Me.cmb_Forms.Items.AddRange(New Object() {"Nothing"})
        Me.cmb_Forms.Location = New System.Drawing.Point(3, 52)
        Me.cmb_Forms.Name = "cmb_Forms"
        Me.cmb_Forms.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Forms.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.cmb_Forms, "The form is detected according to Pokémon Type.")
        '
        'lst_Numbers
        '
        Me.lst_Numbers.FormattingEnabled = True
        Me.lst_Numbers.Location = New System.Drawing.Point(114, 33)
        Me.lst_Numbers.Name = "lst_Numbers"
        Me.lst_Numbers.Size = New System.Drawing.Size(45, 134)
        Me.lst_Numbers.TabIndex = 12
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Pokémon Online Export to Text Program made by"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(543, 150)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "IAL32"
        '
        'btn_Export
        '
        Me.btn_Export.Location = New System.Drawing.Point(12, 7)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(96, 58)
        Me.btn_Export.TabIndex = 16
        Me.btn_Export.Text = "Export"
        Me.btn_Export.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(311, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(326, 140)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmb_Nature)
        Me.TabPage1.Controls.Add(Me.cmb_Trait)
        Me.TabPage1.Controls.Add(Me.cmb_Items)
        Me.TabPage1.Controls.Add(Me.rd_Female)
        Me.TabPage1.Controls.Add(Me.cmb_Move4)
        Me.TabPage1.Controls.Add(Me.rd_Male)
        Me.TabPage1.Controls.Add(Me.cmb_Move3)
        Me.TabPage1.Controls.Add(Me.cmb_Move2)
        Me.TabPage1.Controls.Add(Me.cmb_Move1)
        Me.TabPage1.Controls.Add(Me.cmb_Forms)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(318, 114)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ComboBoxs"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmb_Items
        '
        Me.cmb_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Items.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_Items.FormattingEnabled = True
        Me.cmb_Items.Items.AddRange(New Object() {"(No Item)", "Big Root", "Blue Scarf", "BrightPowder", "Choice Band", "Choice Scarf", "Choice Specs", "Destiny Knot", "Expert Belt", "Focus Band", "Focus Sash", "Full Incense", "Green Scarf", "Lagging Tail", "Lax Incense", "Leftovers", "Luck Incense", "Mental Herb", "Metal Powder", "Muscle Band", "Odd Incense", "Pink Scarf", "Power Herb", "Pure Incense", "Quick Powder", "Reaper Cloth", "Red Scarf", "Rock Incense", "Rose Incense", "Sea Incense", "Shed Shell", "Silk Scarf", "Silver Powder", "Smooth Rock", "Soft Sand", "Soothe Bell", "Wave Incense", "White Herb", "Wide Lens", "Wise Glasses", "Yellow Scarf", "Zoom Lens", "Amulet Coin", "Antidote", "Awakening", "Berry Juice", "Big Pearl", "Big Mushroom", "Black Belt", "Black Flute", "Black Sludge", "BlackGlasses", "Blue Flute", "Blue Shard", "Burn Heal", "Calcium", "Carbos", "Charcoal", "Cleanse Tag", "Damp Mulch", "DeepSeaScale", "Dire Hit", "Dragon Scale", "Elixir", "Energy Root", "EnergyPowder", "Escape Rope", "Ether", "Everstone", "Exp. Share", "Fire Stone", "Flame Orb", "Fluffy Tail", "Fresh Water", "Full Heal", "Full Restore", "Gooey Mulch", "Green Shard", "Growth Mulch", "Guard Spec.", "Heal Powder", "Heart Scale", "Honey", "HP Up", "Hyper Potion", "Ice Heal", "Iron", "King's Rock", "Lava Cookie", "Leaf Stone", "Lemonade", "Life Orb", "Light Ball", "Light Clay", "Lucky Egg", "Magnet", "Max Elixir", "Max Ether", "Max Potion", "Max Repel", "Max Revive", "Metal Coat", "Metronome", "Miracle Seed", "MooMoo Milk", "Moon Stone", "Mystic Water", "NeverMeltIce", "Nugget", "Old Gateau", "Parlyz Heal", "Pearl", "Pok� Doll", "Potion", "PP Max", "PP Up", "Protein", "Rare Candy", "Razor Fang", "Red Flute", "Red Shard", "Repel", "Revival Herb", "Revive", "Sacred Ash", "Scope Lens", "Shell Bell", "Shoal Salt", "Shoal Shell", "Smoke Ball", "Soda Pop", "Soul Dew", "Spell Tag", "Stable Mulch", "Star Piece", "Stardust", "Sun Stone", "Super Potion", "Super Repel", "Thunderstone", "TinyMushroom", "Toxic Orb", "TwistedSpoon", "Up-Grade", "Water Stone", "White Flute", "X Accuracy", "X Attack", "X Defend", "X Special", "X Sp. Def", "X Speed", "Yellow Flute", "Yellow Shard", "Zinc", "Icy Rock", "Lucky Punch", "Dubious Disc", "Sharp Beak", "Adamant Orb", "Damp Rock", "Heat Rock", "Lustrous Orb", "Macho Brace", "Stick", "Dragon Fang", "Poison Barb", "Power Anklet", "Power Band", "Power Belt", "Power Bracer", "Power Lens", "Power Weight", "Dawn Stone", "Dusk Stone", "Electirizer", "Magmarizer", "Odd Keystone", "Oval Stone", "Protector", "Quick Claw", "Razor Claw", "Shiny Stone", "Sticky Barb", "DeepSeaTooth", "Draco Plate", "Dread Plate", "Earth Plate", "Fist Plate", "Flame Plate", "Grip Claw", "Icicle Plate", "Insect Plate", "Iron Plate", "Meadow Plate", "Mind Plate", "Sky Plate", "Splash Plate", "Spooky Plate", "Stone Plate", "Thick Club", "Toxic Plate", "Zap Plate", "Armor Fossil", "Claw Fossil", "Dome Fossil", "Hard Stone", "Helix Fossil", "Old Amber", "Rare Bone", "Root Fossil", "Skull Fossil", "Iron Ball", "Griseous Orb", "Air Mail", "Bloom Mail", "Brick Mail", "Bubble Mail", "Flame Mail", "Grass Mail", "Harbor Mail", "Heart Mail", "Mosaic Mail", "Snow Mail", "Space Mail", "Steel Mail", "Tunnel Mail", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "Sweet Heart", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fight Gem", "Poison Gem", "Earth Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Dream Ball", "BalmMushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Special 2", "X Sp. Def 2", "X Defend 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Special 3", "X Sp. Def 3", "X Defend 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Special 6", "X Sp. Def 6", "X Defend 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Berserk Gene", "Pink Bow", "Polkadot Bow"})
        Me.cmb_Items.Location = New System.Drawing.Point(130, 52)
        Me.cmb_Items.Name = "cmb_Items"
        Me.cmb_Items.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Items.TabIndex = 30
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.nup_EVSpd)
        Me.TabPage2.Controls.Add(Me.nup_EVSDef)
        Me.TabPage2.Controls.Add(Me.nup_EVSAtk)
        Me.TabPage2.Controls.Add(Me.nup_EVDef)
        Me.TabPage2.Controls.Add(Me.nup_EVAtk)
        Me.TabPage2.Controls.Add(Me.nup_EVHP)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(318, 114)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "EVs | Sum: 0"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(122, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Spd"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(122, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "SDef"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "SAtk"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Def"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Atk"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "HP"
        '
        'nup_EVSpd
        '
        Me.nup_EVSpd.ForeColor = System.Drawing.Color.Black
        Me.nup_EVSpd.Location = New System.Drawing.Point(192, 32)
        Me.nup_EVSpd.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nup_EVSpd.Name = "nup_EVSpd"
        Me.nup_EVSpd.Size = New System.Drawing.Size(40, 20)
        Me.nup_EVSpd.TabIndex = 17
        '
        'nup_EVSDef
        '
        Me.nup_EVSDef.ForeColor = System.Drawing.Color.Black
        Me.nup_EVSDef.Location = New System.Drawing.Point(192, 6)
        Me.nup_EVSDef.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nup_EVSDef.Name = "nup_EVSDef"
        Me.nup_EVSDef.Size = New System.Drawing.Size(40, 20)
        Me.nup_EVSDef.TabIndex = 16
        '
        'nup_EVSAtk
        '
        Me.nup_EVSAtk.ForeColor = System.Drawing.Color.Black
        Me.nup_EVSAtk.Location = New System.Drawing.Point(76, 82)
        Me.nup_EVSAtk.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nup_EVSAtk.Name = "nup_EVSAtk"
        Me.nup_EVSAtk.Size = New System.Drawing.Size(40, 20)
        Me.nup_EVSAtk.TabIndex = 15
        '
        'nup_EVDef
        '
        Me.nup_EVDef.ForeColor = System.Drawing.Color.Black
        Me.nup_EVDef.Location = New System.Drawing.Point(76, 56)
        Me.nup_EVDef.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nup_EVDef.Name = "nup_EVDef"
        Me.nup_EVDef.Size = New System.Drawing.Size(40, 20)
        Me.nup_EVDef.TabIndex = 14
        '
        'nup_EVAtk
        '
        Me.nup_EVAtk.ForeColor = System.Drawing.Color.Black
        Me.nup_EVAtk.Location = New System.Drawing.Point(76, 30)
        Me.nup_EVAtk.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nup_EVAtk.Name = "nup_EVAtk"
        Me.nup_EVAtk.Size = New System.Drawing.Size(40, 20)
        Me.nup_EVAtk.TabIndex = 13
        '
        'nup_EVHP
        '
        Me.nup_EVHP.ForeColor = System.Drawing.Color.Black
        Me.nup_EVHP.Location = New System.Drawing.Point(76, 3)
        Me.nup_EVHP.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nup_EVHP.Name = "nup_EVHP"
        Me.nup_EVHP.Size = New System.Drawing.Size(40, 20)
        Me.nup_EVHP.TabIndex = 12
        '
        'cmb_Nature
        '
        Me.cmb_Nature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Nature.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_Nature.FormattingEnabled = True
        Me.cmb_Nature.Items.AddRange(New Object() {"Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky"})
        Me.cmb_Nature.Location = New System.Drawing.Point(130, 74)
        Me.cmb_Nature.Name = "cmb_Nature"
        Me.cmb_Nature.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Nature.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 172)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_Export)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_SearchText)
        Me.Controls.Add(Me.lst_Numbers)
        Me.Controls.Add(Me.lst_Pokemon)
        Me.Controls.Add(Me.btn_Pokemon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokémon Online - Export to Text"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nup_EVSpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_EVSDef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_EVSAtk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_EVDef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_EVAtk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_EVHP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Pokemon As System.Windows.Forms.Button
    Friend WithEvents lst_Pokemon As System.Windows.Forms.ListBox
    Friend WithEvents rd_Male As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Female As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lst_Numbers As System.Windows.Forms.ListBox
    Friend WithEvents txt_SearchText As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_Export As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmb_Trait As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Items As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Move4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Move3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Move2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Move1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Forms As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents nup_EVSpd As System.Windows.Forms.NumericUpDown
    Friend WithEvents nup_EVSDef As System.Windows.Forms.NumericUpDown
    Friend WithEvents nup_EVSAtk As System.Windows.Forms.NumericUpDown
    Friend WithEvents nup_EVDef As System.Windows.Forms.NumericUpDown
    Friend WithEvents nup_EVAtk As System.Windows.Forms.NumericUpDown
    Friend WithEvents nup_EVHP As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmb_Nature As System.Windows.Forms.ComboBox

End Class
