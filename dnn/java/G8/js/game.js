var game = new Phaser.Game(800, 600, Phaser.CANVAS, 'gameDiv', { render: playState.render });


game.state.add('boot', bootState);
game.state.add('load', loadState);
game.state.add('menu', menuState);
game.state.add('play', playState);
game.state.add('win', winState);
game.state.add('lose', loseState);

game.state.start('boot');