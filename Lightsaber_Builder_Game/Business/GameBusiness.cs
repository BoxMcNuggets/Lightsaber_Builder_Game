﻿using System;
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
        bool _newPlayer = true;

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
        private void InitializeDataSet()
        {
            _player = GameData.PlayerData();
            _gamemap = GameData.GameMap();
        }
        private void InstantiateAndShowView()
        {
            //
            // instantiate the view model and initialize the data set
            //
            _gameSessionViewModel = new GameSessionViewModel(_player, _gamemap);
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();
        }
    }
}
