using Uaine.Coord;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Uaine.ScreenScraper;

namespace Uaine.MultiMonitorGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class MMG : Game
    {
        protected GraphicsDeviceManager graphics;
        protected SpriteBatch spriteBatch;
        protected coord screensize = new coord(800, 600);
        protected KeyboardState ksold = Keyboard.GetState();
        protected KeyboardState ks = Keyboard.GetState();
        protected MouseState msold = Mouse.GetState();
        protected MouseState ms = Mouse.GetState();
        protected int monitorindex;

        public MMG(int monitor, bool fullscreen)
        {
            monitorindex = monitor;
            //get screen
            ScreenInfo si = scraper.GetScreen(monitor);
            this.Window.Position = new Point(si.pos.x, si.pos.y);
            graphics = new GraphicsDeviceManager(this);
            //set the GraphicsDeviceManager's fullscreen property
            graphics.PreferredBackBufferWidth = GraphicsAdapter.Adapters[monitor].CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsAdapter.Adapters[monitor].CurrentDisplayMode.Height;
            graphics.HardwareModeSwitch = false;
            graphics.IsFullScreen = fullscreen;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            ksold = ks;
            msold = ms;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

            base.Draw(gameTime);
        }
    }
}
