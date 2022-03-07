using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearstone.Classes
{
    class Minion: Card
    {
        public int ActualHealth { get; set; }
        public void DoAttack(Minion target)
        {
            target.ActualHealth -= Attack;
            ActualHealth -= target.Attack;
        }


    }
}
