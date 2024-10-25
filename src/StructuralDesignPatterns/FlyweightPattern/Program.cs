using FlyweightPattern;

IPlayer mainPlayer = PlayersFactory.GetPlayer(PlayerType.MAIN_PLAYER);
mainPlayer.AssignWeapon(new Weapon("AK47", 0));
mainPlayer.Attack();

IPlayer weakEnemy = PlayersFactory.GetPlayer(PlayerType.WEAK_ENEMY);
weakEnemy.Attack();

IPlayer weakEnemy2 = PlayersFactory.GetPlayer(PlayerType.WEAK_ENEMY);
weakEnemy2.Attack();

IPlayer strongEnemy = PlayersFactory.GetPlayer(PlayerType.STRONG_ENEMY);
strongEnemy.Attack();