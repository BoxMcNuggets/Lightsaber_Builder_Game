using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lightsaber_Builder_Game.Presentation;
using Lightsaber_Builder_Game.DataLayer;
using Lightsaber_Builder_Game.Models;

namespace Lightsaber_Builder_Game.Business
{
    public class GameBusiness
    {
        bool _newPlayer = false;

        GameSessionViewModel _gameSessionViewModel;
        Player _player = new Player();
        GameSetupView _playerSetupView;
        Map _gamemap;

        public GameBusiness()
        {
            SetupPlayer();
            InitializeDataSet();
            InstantiateAndShowView();
        }

        /// <summary>
        /// setup new or existing player
        /// </summary>
        private void SetupPlayer()
        {
            if (_newPlayer)
            {
                _playerSetupView = new GameSetupView(_player);
                _playerSetupView.ShowDialog();

                //
                // setup up game based player properties
                //
            }
            else
            {
                _player = GameData.PlayerData();
            }
        }

        /// <summary>
        /// initialize data set
        /// </summary>
        private void InitializeDataSet()
        {
            _player = GameData.PlayerData();
            _gamemap = GameData.GameMap();
        }

        /// <summary>
        /// create view model with data set
        /// </summary>
        private void InstantiateAndShowView()
        {
            //
            // instantiate the view model and initialize the data set
            //
            _gameSessionViewModel = new GameSessionViewModel(_player, _gamemap);
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

            //
            // dialog window is initially hidden to mitigate issue with
            // main window closing after dialog window closes
            //
            // commented out because the player setup window is disabled
            //
            //_playerSetupView.Close();
        }
    }
}
