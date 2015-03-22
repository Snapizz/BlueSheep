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
            InitEs();
            InitPt();
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

        private void InitEs()
        {
            _data.Add(Il8NBsLang.Es, new Dictionary<Il8NBsEnum, string>
            {
                { Il8NBsEnum.AccountUcName, "Nombre" },
                { Il8NBsEnum.AccountUcUid, "UID" },
                { Il8NBsEnum.AccountUcGid, "GID" },
                { Il8NBsEnum.AccountUcQuantity, "Cantidad" },
                { Il8NBsEnum.AccountUcType, "Tipo" },
                { Il8NBsEnum.AccountUcAveragePrice, "Precio medio" },
                { Il8NBsEnum.AccountUcNextMeal, "Comida próxima" },
                { Il8NBsEnum.AccountUcStats, "Características" },
                { Il8NBsEnum.AccountUcFight, "Combate" },
                { Il8NBsEnum.AccountUcPets, "Mascotas" },
                { Il8NBsEnum.AccountUcInventory, "Inventario" },
                { Il8NBsEnum.AccountUcDivers, "Vario" },
                { Il8NBsEnum.AccountUcJobs, "profesión" },
                { Il8NBsEnum.AccountUcSettings, "Parámetros" },
                { Il8NBsEnum.AccountUcHouses, "Casas" },
                { Il8NBsEnum.AccountUcLifePercent, "% de vida" },
                { Il8NBsEnum.AccountUcAi, "AI" },
                { Il8NBsEnum.AccountUcChooseAi, "IA seleccionado" },
                { Il8NBsEnum.AccountUcCreateAi, "crear una IA" },
                { Il8NBsEnum.AccountUcNoAi, "No AI" },
                { Il8NBsEnum.AccountUcMonstersNumber, "Número de monstruos" },
                { Il8NBsEnum.AccountUcMonsterLevel, "Niveles de los monstruos" },
                { Il8NBsEnum.AccountUcStartFeeding, "Empezar la ganadería" },
                { Il8NBsEnum.AccountUcConnectDisconnect, "Conectar/Desconectar" },
                { Il8NBsEnum.AccountUcPath, "Trayecto" },
                { Il8NBsEnum.AccountUcLaunchPath, "Lanzar el trayecto" },
                { Il8NBsEnum.AccountUcLoadPath, "Cargar un trayecto" },
                { Il8NBsEnum.AccountUcStopPath, "Parar el trayecto" },
                { Il8NBsEnum.AccountUcFood, "Alimento (cantidad)" }
            });
        }

        private void InitPt()
        {
            _data.Add(Il8NBsLang.Pt, new Dictionary<Il8NBsEnum, string>
            {
                { Il8NBsEnum.AccountUcName, "Nome" },
                { Il8NBsEnum.AccountUcUid, "UID" },
                { Il8NBsEnum.AccountUcGid, "GID" },
                { Il8NBsEnum.AccountUcQuantity, "Quantidade" },
                { Il8NBsEnum.AccountUcType, "Tipo" },
                { Il8NBsEnum.AccountUcAveragePrice, "Preço médio" },
                { Il8NBsEnum.AccountUcNextMeal, "Próxima refeição" },
                { Il8NBsEnum.AccountUcStats, "Características" },
                { Il8NBsEnum.AccountUcFight, "Luta" },
                { Il8NBsEnum.AccountUcPets, "Animais" },
                { Il8NBsEnum.AccountUcInventory, "Inventário" },
                { Il8NBsEnum.AccountUcDivers, "Diverso" },
                { Il8NBsEnum.AccountUcJobs, "Jobs" },
                { Il8NBsEnum.AccountUcSettings, "Parâmetros" },
                { Il8NBsEnum.AccountUcHouses, "Casas" },
                { Il8NBsEnum.AccountUcLifePercent, "% de vida" },
                { Il8NBsEnum.AccountUcAi, "AI" },
                { Il8NBsEnum.AccountUcChooseAi, "Escolha um IA" },
                { Il8NBsEnum.AccountUcCreateAi, "Crie um IA" },
                { Il8NBsEnum.AccountUcNoAi, "No AI" },
                { Il8NBsEnum.AccountUcMonstersNumber, "Número de monstros" },
                { Il8NBsEnum.AccountUcMonsterLevel, "Nível de monstros" },
                { Il8NBsEnum.AccountUcStartFeeding, "Comece a procriação" },
                { Il8NBsEnum.AccountUcConnectDisconnect, "Conecte / desconecte" },
                { Il8NBsEnum.AccountUcPath, "Trajecto" },
                { Il8NBsEnum.AccountUcLaunchPath, "Lance a trajecto" },
                { Il8NBsEnum.AccountUcLoadPath, "Carregue (Custo) um trajecto" },
                { Il8NBsEnum.AccountUcStopPath, "Parada trajecto" },
                { Il8NBsEnum.AccountUcFood, "Comida (quantidade)" }
            });
        }

        public string Get(Il8NBsEnum key)
        {
            var lang = _data.ContainsKey(Lang) ? Lang : Il8NBsLang.Fr;
            return _data[lang].ContainsKey(key) ? _data[lang][key] : _data[Il8NBsLang.Fr][key];
        }
    }
}
