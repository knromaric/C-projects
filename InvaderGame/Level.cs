
namespace InvaderGame
{
    public class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] Towers { get; set;}

        public Level(Invader[] invaders)
        {
            _invaders = invaders; 
        }

        //return true if the player wins, and false otherwise.
        public bool Play()
        {
            //Run until all invaders are neutralized or an invader reaches the end of the path
            int remainingInvaders = _invaders.Length; 
            
            while(remainingInvaders > 0)
            {
                //Each tower has opportunity to fire on invaders 
                foreach (var tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }
                //count and move the invaders that are still active
                remainingInvaders = 0;
                foreach (var invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;

                    }
                        
                }
            }

            return true; 
        }
    }
}
