using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Zeldious.Studio.Paws_of_Peril.Entities;

namespace Zeldious.Studio.Paws_of_Peril.Windows
{
    public class MainGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Player _player;

        public MainGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 800;

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Créer le joueur
            _player = new Player();
            _player.Position = new Vector2(50, 700);
            _player.Sprite = new Texture2D(GraphicsDevice, 1, 1);
            _player.Sprite.SetData(new[] { Color.White });
            
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // environ 1/30ème de la largeur de l'écran
            var largeur = GraphicsDevice.Viewport.Width / 30;
            // environ 1/15ème de la hauteur de l'écran
            var hauteur = GraphicsDevice.Viewport.Height / 15;

            _spriteBatch.Begin();
            // Dessine le joueur
            _spriteBatch.Draw(_player.Sprite, new Rectangle((int)_player.Position.X, (int)_player.Position.Y, largeur, hauteur), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}