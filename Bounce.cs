using InfinityScript;

namespace Bounce
{
    public class Bounce : BaseScript
    {
        /// <summary>
        /// This code will nop server functions to allow the client to bounce like on cod4. To allow the client to bounce see my other project
        /// </summary>
        public Bounce()
        {
            unsafe
            {
                int[] addr = { 0x0422AB6, 0x0422AAF, 0x041E00C, 0x0414127, 0x04141b4, 0x0414e027, 0x0414b126, 0x041416d, 0x041417c };
                byte nop = 0x90;
                for (int i = 0; i < 7; ++i)
                {

                    *((byte*)addr[7] + i) = nop;
                    *((byte*)addr[8] + i) = nop;
                    *((byte*)addr[i]) = nop;
                    *((byte*)(addr[i] + 1)) = nop;
                }
            }
        }
    }
}