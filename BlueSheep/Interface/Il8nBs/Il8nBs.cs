using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlueSheep.Interface.Il8nBs
{
    public class Il8NBs
    {
        public Il8NBsLang Lang { get; set; }

        private Dictionary<Il8NBsLang, Dictionary<Il8NBsEnum, string>> _data;

        private static readonly Lazy<Il8NBs> lazy =
        new Lazy<Il8NBs>(() => new Il8NBs());

        public static Il8NBs Instance { get { return lazy.Value; } }

        public Il8NBs()
        {
            Lang = Il8NBsLang.Fr;
            Init();
        }

        public Il8NBs(Il8NBsLang lang)
        {
            Lang = lang;
            Init();
        }

        private void Init()
        {
            _data = new Dictionary<Il8NBsLang, Dictionary<Il8NBsEnum, string>>();

            InitFr();
            InitEn();
        }

        private void InitFr()
        {
            _data.Add(Il8NBsLang.Fr, new Dictionary<Il8NBsEnum, string>
            {
                { Il8NBsEnum.AccountUcName, "Nom" },
                { Il8NBsEnum.AccountUcUid, "UID" },
                { Il8NBsEnum.AccountUcGid, "GID" },
                { Il8NBsEnum.AccountUcQuantity, "Quantité" },
                { Il8NBsEnum.AccountUcType, "Type" },
                { Il8NBsEnum.AccountUcAveragePrice, "Prix moyen" },
                { Il8NBsEnum.AccountUcNextMeal, "Prochain repas" },
                { Il8NBsEnum.AccountUcStats, "Caractéristiques" },
                { Il8NBsEnum.AccountUcFight, "Combat" },
                { Il8NBsEnum.AccountUcPets, "Familiers" },
                { Il8NBsEnum.AccountUcInventory, "Inventaire" },
                { Il8NBsEnum.AccountUcDivers, "Divers" },
                { Il8NBsEnum.AccountUcJobs, "Métiers" },
                { Il8NBsEnum.AccountUcSettings, "Configuration" },
                { Il8NBsEnum.AccountUcHouses, "Maisons" },
                { Il8NBsEnum.AccountUcLifePercent, "% de vie" },
                { Il8NBsEnum.AccountUcAi, "IA" },
                { Il8NBsEnum.AccountUcChooseAi, "Choisir une IA" },
                { Il8NBsEnum.AccountUcCreateAi, "Créer une IA" },
                { Il8NBsEnum.AccountUcNoAi, "No IA" },
                { Il8NBsEnum.AccountUcMonstersNumber, "Nombre de monstres" },
                { Il8NBsEnum.AccountUcMonsterLevel, "level des montres" },
                { Il8NBsEnum.AccountUcStartFeeding, "Caractéristiques" },
                { Il8NBsEnum.AccountUcConnectDisconnect, "Connecter/Déconnecter" },
                { Il8NBsEnum.AccountUcPath, "Trajet" },
                { Il8NBsEnum.AccountUcLaunchPath, "Lancer trajet" },
                { Il8NBsEnum.AccountUcLoadPath, "Charger trajet" },
                { Il8NBsEnum.AccountUcStopPath, "Stop trajet" },
                { Il8NBsEnum.AccountUcFood, "Nourriture (Quantité)" }
            });
        }

        private void InitEn()
        {
            _data.Add(Il8NBsLang.En, new Dictionary<Il8NBsEnum, string>
            {
                { Il8NBsEnum.AccountUcName, "Name" },
                { Il8NBsEnum.AccountUcUid, "UID" },
                { Il8NBsEnum.AccountUcGid, "GID" },
                { Il8NBsEnum.AccountUcQuantity, "Quantity" },
                { Il8NBsEnum.AccountUcType, "Type" },
                { Il8NBsEnum.AccountUcAveragePrice, "Average Price" },
                { Il8NBsEnum.AccountUcNextMeal, "Next meal" },
                { Il8NBsEnum.AccountUcStats, "Stats" },
                { Il8NBsEnum.AccountUcFight, "Fight" },
                { Il8NBsEnum.AccountUcPets, "Pets" },
                { Il8NBsEnum.AccountUcInventory, "Inventory" },
                { Il8NBsEnum.AccountUcDivers, "Divers" },
                { Il8NBsEnum.AccountUcJobs, "Jobs" },
                { Il8NBsEnum.AccountUcSettings, "Settings" },
                { Il8NBsEnum.AccountUcHouses, "Houses" },
                { Il8NBsEnum.AccountUcLifePercent, "% of life" },
                { Il8NBsEnum.AccountUcAi, "AI" },
                { Il8NBsEnum.AccountUcChooseAi, "Choose an AI" },
                { Il8NBsEnum.AccountUcCreateAi, "Create an AI" },
                { Il8NBsEnum.AccountUcNoAi, "No AI" },
                { Il8NBsEnum.AccountUcMonstersNumber, "Numbers of monsters" },
                { Il8NBsEnum.AccountUcMonsterLevel, "Levels of monsters" },
                { Il8NBsEnum.AccountUcStartFeeding, "Stats" },
                { Il8NBsEnum.AccountUcConnectDisconnect, "Connect/Disconnect" },
                { Il8NBsEnum.AccountUcPath, "Path" },
                { Il8NBsEnum.AccountUcLaunchPath, "Launch path" },
                { Il8NBsEnum.AccountUcLoadPath, "Load path" },
                { Il8NBsEnum.AccountUcStopPath, "Stop path" },
                { Il8NBsEnum.AccountUcFood, "Food (Quantity)" }
            });
        }

        public string Get(Il8NBsEnum key)
        {
            var lang = _data.ContainsKey(Lang) ? Lang : Il8NBsLang.Fr;
            return _data[lang].ContainsKey(key) ? _data[lang][key] : _data[Il8NBsLang.Fr][key];
        }
    }
}
