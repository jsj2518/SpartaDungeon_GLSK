﻿using SpartaDungeon_GLSK.Data;
using SpartaDungeon_GLSK.Scene;
using System.Runtime.CompilerServices;

namespace SpartaDungeon_GLSK
{
    public class Program
    {
        static SceneManager sceneManager = new SceneManager();

        public static PlayerData playerData;
        public static IngameData ingameData = new IngameData();

        public ShopScene shopScene = new ShopScene();

        static void Main(string[] args)
        {
            ShopScene.Set();
            GuildScene.Set();

            sceneManager.Start();
        }
    }
}
