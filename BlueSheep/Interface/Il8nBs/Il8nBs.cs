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

        private Dictionary<int, Dictionary<int, string>> _data;

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
            _data = new Dictionary<int, Dictionary<int, string>>();

            InitFr();
        }

        private void InitFr()
        {
            _data.Add((int) Il8NBsLang.Fr, new Dictionary<int, string>
            {
                { (int) Il8NBsEnum.AccountUcName, "Nom" },
                { (int) Il8NBsEnum.AccountUcUid, "UID" },
                { (int) Il8NBsEnum.AccountUcGid, "GID" },
                { (int) Il8NBsEnum.AccountUcQuantity, "Quantité" },
                { (int) Il8NBsEnum.AccountUcType, "Type" },
                { (int) Il8NBsEnum.AccountUcAveragePrice, "Prix moyen" },
                { (int) Il8NBsEnum.AccountUcNextMeal, "Prochain repas" },
                { (int) Il8NBsEnum.AccountUcStats, "Caractéristiques" },
                { (int) Il8NBsEnum.AccountUcFight, "Combat" },
                { (int) Il8NBsEnum.AccountUcPets, "Familiers" },
                { (int) Il8NBsEnum.AccountUcInventory, "Inventaire" },
                { (int) Il8NBsEnum.AccountUcDivers, "Divers" },
                { (int) Il8NBsEnum.AccountUcJobs, "Métiers" },
                { (int) Il8NBsEnum.AccountUcSettings, "Configuration" },
                { (int) Il8NBsEnum.AccountUcHouses, "Maisons" },
                { (int) Il8NBsEnum.AccountUcLifePercent, "% de vie" },
                { (int) Il8NBsEnum.AccountUcAi, "IA" },
                { (int) Il8NBsEnum.AccountUcChooseAi, "Choisir une IA" },
                { (int) Il8NBsEnum.AccountUcCreateAi, "Créer une IA" },
                { (int) Il8NBsEnum.AccountUcAiName, "Npm IA" },
                { (int) Il8NBsEnum.AccountUcMonstersNumber, "Nombre de monstres" },
                { (int) Il8NBsEnum.AccountUcMonsterLevel, "level des montres" },
                { (int) Il8NBsEnum.AccountUcStartFeeding, "Caractéristiques" },
                { (int) Il8NBsEnum.AccountUcConnectDisconnect, "Connecter/Déconnecter" },
                { (int) Il8NBsEnum.AccountUcPath, "Trajet" },
                { (int) Il8NBsEnum.AccountUcLaunchPath, "Lancer trajet" },
                { (int) Il8NBsEnum.AccountUcLoadPath, "Charger trajet" },
                { (int) Il8NBsEnum.AccountUcStopPath, "Stop trajet" },
                { (int) Il8NBsEnum.AccountUcFood, "Nourriture (Quantité)" }
            });
        }

        public string Get(Il8NBsEnum key)
        {
            var lang = _data.ContainsKey((int)Lang) ? Lang : Il8NBsLang.Fr;
            return _data[(int)lang].ContainsKey((int)key) ? _data[(int)lang][(int)key] : _data[(int)Il8NBsLang.Fr][(int)key];
        }
    }
}
