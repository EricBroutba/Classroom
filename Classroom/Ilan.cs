﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classroom
{
    class Ilan
    {

        public float height;
        public int age;
        public string eye_color;
        public string hair_color;
        public float weight;
        List<string> sports;
        List<string> hobbys;
        public string work;
        public DateTime birthday;
        public bool righthanded;
        public string favorite_song;
        public string favorite_movie;
        public string favorite_game;
        public string gender;
        public string dream;
        public string town;
        public string feeling;

        public int px;
        public int py;


        public Ilan(int x, int y)
        {
            px = x;
            py = y;
            sports = new List<string>();
            hobbys = new List<string>();

        }

        public void draw(Graphics G) {

            Pen P = new Pen(Color.Black);
            G.DrawLine(P, px, py, px += 50, py);
            G.DrawLine(P, px, py, px, py += 50);
            G.DrawLine(P, px, py, px -= 50, py);
            G.DrawLine(P, px, py, px, py -= 50);
            
        }

        
    }
}
