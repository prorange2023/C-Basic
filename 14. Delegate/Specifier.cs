using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    internal class Specifier
    {
        /*******************************************************************
         * 지정자 (Specifier)
         * 
         * 델리게이트를 사용하여 미완성 상태의 함수를 구성
         * 매개변수로 전달한 지정자를 기준으로 함수를 완성하여 동작시킴
         * 기준을 정해주는 것으로 다양한 결과가 나올 수 있는 함수를 구성가능
         ********************************************************************/

        // <델리게이트를 지정자로 사용>
        // 매개변수로 함수에 필요한 기준을 전달
        // 전달한 기준을 통해 결과를 도출
        public class Item
        {
            public string name;
            public int level;
            public float weight;



            public Item(string name, int level, float weight)
            {
                this.name = name;
                this.level = level;
                this.weight = weight;
            }
        }
        void Main()
        {
            Item[] inventory = new Item[5];

            inventory[0] = new Item("포션", 3, 3.2f);
            inventory[1] = new Item("갑옷", 2, 1.2f);
            inventory[2] = new Item("무기", 1, 4.5f);
            inventory[3] = new Item("방패", 8, 8.8f);
            inventory[4] = new Item("폭탄", 6, 12.6f);

            int index1 = FindIndex(inventory, FindByName);
            /*윗줄의 FindByName 은 다음 내용으로 대체가능 (item) => {return item.name =="포션"*/
            // 이많은 것중 바뀌는건 단 한줄임 조건 이거만 바꾸는 형식으로 효율적코딩해보기

        }
        public static bool FindByName(Item item)
        {
            return item.name == "방패";
        }

        public static bool FindWeight6(Item item)
        {
            return item.weight == 6;
        }
        public static int FindIndex(Item[] inventory, Predicate<Item> predicate)
        // 윗줄 predicate 가 조건부니까 저기만 어케하면 각종 조건으로 다 찾기 가능
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (predicate(inventory[i]))
                {
                    return i;
                    
                }
                return -1;
                
            }
        }
    }
}
