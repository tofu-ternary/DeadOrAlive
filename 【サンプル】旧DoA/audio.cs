using WMPLib;

namespace test
{
    class Audio
    {
        private static WindowsMediaPlayer bgm;//BGM

        private static WindowsMediaPlayer enda;//BGM
        private static WindowsMediaPlayer endb;//BGM


        private static WindowsMediaPlayer end_storya;
        private static WindowsMediaPlayer end_storyb;
        private static WindowsMediaPlayer end_storyc;
        private static WindowsMediaPlayer end_storyd;
        private static WindowsMediaPlayer end_storye;
        private static WindowsMediaPlayer end_storyf;
        private static WindowsMediaPlayer end_storyg;

        private static WindowsMediaPlayer menu_in = new WindowsMediaPlayer();
        private static WindowsMediaPlayer menu_out = new WindowsMediaPlayer();//

        private static WindowsMediaPlayer mis_in = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer mis_out = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer mis_dis = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer menu_dis = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer item_dis = new WindowsMediaPlayer();//

        private static WindowsMediaPlayer title = new WindowsMediaPlayer();//BGM


        //効果音
        private static WindowsMediaPlayer bath_spill = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer bed_move = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer block_fall = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer book_open = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer box_max = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer chain_cut = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer chain_move = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer chain_set = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer chair_move = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer display_on = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer dool_fine = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer door_open = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer enddoor_open = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer failed = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer fall_key = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer hidesafe_open = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer light_move = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer locker_open = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer mato_put = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer moneybox_open = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer move = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer object_lie = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer plate_set = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer prison_open = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer slide_door = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer stair_discovery = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer stairs_open = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer success = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer switch_onf = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer tower_disappear = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer triangle_change = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer valve_set = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer vase_break = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer warning = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer water_fall = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer water_spill = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer wood_put = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer wood_fire = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer clean_wall = new WindowsMediaPlayer();//
        private static WindowsMediaPlayer keyboard = new WindowsMediaPlayer();//

        internal static void Load()
        {

            bgm = new WindowsMediaPlayer();
            enda = new WindowsMediaPlayer();
            endb = new WindowsMediaPlayer();
            bgm.settings.setMode("loop", true);
            bgm.settings.autoStart = false;
            bgm.URL = "bgm.mp3";
            bgm.settings.volume = 15; // 0から100 40

            title.settings.setMode("loop", true);
            title.settings.autoStart = true;
            title.URL = "title.mp3";
            title.settings.volume = 15; // 0から100 40

            endb.settings.autoStart = false;
            endb.URL = "endb.mp3";
            endb.settings.volume = 100;
            enda.settings.autoStart = false;
            enda.URL = "enda.mp3";
            enda.settings.volume = 100; // 0から100 40

            menu_in.settings.autoStart = false;
            menu_out.settings.autoStart = false;

            mis_in.settings.autoStart = false;
            mis_out.settings.autoStart = false;
            mis_dis.settings.autoStart = false;
            menu_dis.settings.autoStart = false;
            item_dis.settings.autoStart = false;
            menu_in.URL = "menuin.mp3";
            menu_out.URL = "menuout.mp3";

            mis_in.URL = "menuin.mp3";
            mis_out.URL = "menuout.mp3";
            mis_dis.URL = "misdis.mp3";
            menu_dis.URL = "misdis.mp3";
            item_dis.URL = "itemdis.mp3";
            menu_in.settings.volume = 100;
            menu_out.settings.volume = 100;

            mis_in.settings.volume = 100;
            mis_out.settings.volume = 100;
            mis_dis.settings.volume = 100;
            menu_dis.settings.volume = 100;
            item_dis.settings.volume = 100;


            end_storya = new WindowsMediaPlayer();
            end_storyb = new WindowsMediaPlayer();
            end_storyc = new WindowsMediaPlayer();
            end_storyd = new WindowsMediaPlayer();
            end_storye = new WindowsMediaPlayer();
            end_storyf = new WindowsMediaPlayer();
            end_storyg = new WindowsMediaPlayer();

            end_storya.settings.autoStart = false;
            end_storyb.settings.autoStart = false;
            end_storyc.settings.autoStart = false;
            end_storyd.settings.autoStart = false;
            end_storye.settings.autoStart = false;
            end_storyf.settings.autoStart = false;
            end_storyg.settings.autoStart = false;

            end_storya.URL = "storya.mp3";
            end_storyb.URL = "storyb.mp3";
            end_storyc.URL = "storyc.mp3";
            end_storyd.URL = "storydead.mp3";
            end_storye.URL = "storybad.mp3";
            end_storyf.URL = "storys.mp3";
            end_storyg.URL = "storyend.mp3";

            end_storya.settings.volume = 30;
            end_storyb.settings.volume = 30;
            end_storyc.settings.volume = 30;
            end_storyd.settings.volume = 30;
            end_storye.settings.volume = 30;
            end_storyf.settings.volume = 30;
            end_storyg.settings.volume = 30;

            //効果音
            bath_spill.settings.autoStart = false; 
            bed_move.settings.autoStart = false; 
            block_fall.settings.autoStart = false; 
            book_open.settings.autoStart = false; 
            box_max.settings.autoStart = false; 
            chain_cut.settings.autoStart = false; 
            chain_move.settings.autoStart = false; 
            chain_set.settings.autoStart = false; 
            chair_move.settings.autoStart = false; 
            display_on.settings.autoStart = false; 
            dool_fine.settings.autoStart = false; 
            door_open.settings.autoStart = false; 
            enddoor_open.settings.autoStart = false; 
            failed.settings.autoStart = false;
            fall_key.settings.autoStart = false; 
            hidesafe_open.settings.autoStart = false; 
            light_move.settings.autoStart = false; 
            locker_open.settings.autoStart = false; 
            mato_put.settings.autoStart = false; 
            moneybox_open.settings.autoStart = false; 
            move.settings.autoStart = false; 
            object_lie.settings.autoStart = false; 
            plate_set.settings.autoStart = false;
            prison_open.settings.autoStart = false; 
            slide_door.settings.autoStart = false; 
            stair_discovery.settings.autoStart = false; 
            stairs_open.settings.autoStart = false; 
            success.settings.autoStart = false; 
            switch_onf.settings.autoStart = false; 
            tower_disappear.settings.autoStart = false; 
            triangle_change.settings.autoStart = false; 
            valve_set.settings.autoStart = false;
            vase_break.settings.autoStart = false;
            warning.settings.autoStart = false; 
            water_fall.settings.autoStart = false; 
            water_spill.settings.autoStart = false;
            wood_put.settings.autoStart = false;
            wood_fire.settings.autoStart = false;
            clean_wall.settings.autoStart = false;
            keyboard.settings.autoStart = false;

            bath_spill.settings.volume = 100;
            bed_move.settings.volume = 100;
            block_fall.settings.volume = 100;
            book_open.settings.volume = 100;
            box_max.settings.volume = 100;
            chain_cut.settings.volume = 100;
            chain_move.settings.volume = 100;
            chain_set.settings.volume = 100;
            chair_move.settings.volume = 100;
            display_on.settings.volume = 100;
            dool_fine.settings.volume = 100;
            door_open.settings.volume = 100;
            enddoor_open.settings.volume = 100;
            failed.settings.volume = 100;
            fall_key.settings.volume = 100;
            hidesafe_open.settings.volume = 100;
            light_move.settings.volume = 100;
            locker_open.settings.volume = 100;
            mato_put.settings.volume = 100;
            moneybox_open.settings.volume = 100;
            move.settings.volume = 100;
            object_lie.settings.volume = 100;
            plate_set.settings.volume = 100;
            prison_open.settings.volume = 100;
            slide_door.settings.volume = 100;
            stair_discovery.settings.volume = 100;
            stairs_open.settings.volume = 100;
            success.settings.volume = 100;
            switch_onf.settings.volume = 100;
            tower_disappear.settings.volume = 100;
            triangle_change.settings.volume = 100;
            valve_set.settings.volume = 100;
            vase_break.settings.volume = 100;
            warning.settings.volume = 100;
            water_fall.settings.volume = 100;
            water_spill.settings.volume = 100;
            wood_put.settings.volume = 100;
            wood_fire.settings.volume = 100;
            clean_wall.settings.volume = 100;
            keyboard.settings.volume = 100;

            bath_spill.URL = "bath_spill.mp3";//
            bed_move.URL="bed_move.mp3";//
            block_fall.URL="block_fall.mp3";//
            book_open.URL="book_open.mp3";//
            box_max.URL="box_max.mp3";//
            chain_cut.URL="chain_cut.mp3";//
            chain_move.URL="chain_move.mp3";//
            chain_set.URL="chain_set.mp3";//
            chair_move.URL="chair_move.mp3";//
            display_on.URL="display_on.mp3";//
            dool_fine.URL="dool_fine.mp3";//
            door_open.URL="door_open.mp3";//
            enddoor_open.URL="enddoor_open.mp3";//
            failed.URL="failed.mp3";//
            fall_key.URL="fall_key.mp3";//
            hidesafe_open.URL="hidesafe_open.mp3";//
            light_move.URL="light_move.mp3";//
            locker_open.URL="locker_open.mp3";//
            mato_put.URL="mato_put.mp3";//
            moneybox_open.URL="moneybox_open.mp3";//
            move.URL="move.mp3";//
            object_lie.URL="object_lie.mp3";//
            plate_set.URL="plate_set.mp3";//
            prison_open.URL="prison_open.mp3";//
            slide_door.URL="slide_door.mp3";//
            stair_discovery.URL="stair_discovery.mp3";//
            stairs_open.URL="stairs_open.mp3";//
            success.URL="success.mp3";//
            switch_onf.URL="switch_onf.mp3";//
            tower_disappear.URL="tower_disappear.mp3";//
            triangle_change.URL="triangle_change.mp3";//
            valve_set.URL="valve_set.mp3";//
            vase_break.URL="vase_break.mp3";//
            warning.URL="warning.mp3";//
            water_fall.URL="water_fall.mp3";//
            water_spill.URL="water_spill.mp3";//
            wood_put.URL="wood_put.mp3";//
            wood_fire.URL="wood_fire.mp3";//
            clean_wall.URL="clean_wall.mp3";//
            keyboard.URL="keyborad.mp3";//
        }

        internal static void Play_enda()
        {
            enda.controls.play();
        }

        internal static void Play_endb()
        {
            endb.controls.play();
        }

        /*       internal static void Play_enda()
               {
                   enda.controls.play();
               }*/

        internal static void Play_menuin()
        {
            menu_in.controls.play();
        }
        internal static void Play_menuout()
        {
            menu_out.controls.play();
        }

        internal static void Play_misin()
        {
            mis_in.controls.play();
        }
        internal static void Play_misout()
        {
            mis_out.controls.play();
        }
        internal static void Play_misdis()
        {
            mis_dis.controls.play();
        }
        internal static void Play_itemdis()
        {
            item_dis.controls.play();
        }
        internal static void Play_menudis()
        {
            menu_dis.controls.play();
        }

        internal static void Play_bgm()
        {
            bgm.controls.play();
        }
        internal static void Stop_bgm()
        {
            bgm.controls.stop();
        }

        internal static void Play_title()
        {
            title.controls.play();
        }
        internal static void Stop_title()
        {
            title.controls.stop();
        }

        internal static void Play_endstorya()
        {
            end_storya.controls.play();
        }

        internal static void Play_endstoryb()
        {
            end_storyb.controls.play();
        }

        internal static void Play_endstoryc()
        {
            end_storyc.controls.play();
        }

        internal static void Play_endstoryd()
        {
            end_storyd.controls.play();
        }

        internal static void Play_endstorye()
        {
            end_storye.controls.play();
        }

        internal static void Play_endstoryf()
        {
            end_storyf.controls.play();
        }
        internal static void Play_endstoryg()
        {
            end_storyg.controls.play();
        }

        internal static void Stop_endstorya()
        {
            end_storya.controls.stop();
        }

        internal static void Stop_endstoryb()
        {
            end_storyb.controls.stop();
        }

        internal static void Stop_endstoryc()
        {
            end_storyc.controls.stop();
        }

        internal static void Stop_endstoryd()
        {
            end_storyd.controls.stop();
        }

        internal static void Stop_endstorye()
        {
            end_storye.controls.stop();
        }

        internal static void Stop_endstoryf()
        {
            end_storyf.controls.stop();
        }
        internal static void Stop_endstoryg()
        {
            end_storyg.controls.stop();
        }

        //効果音
        internal static void Play_bath_spill()
        {
            bath_spill.controls.play();
        }
        internal static void Play_bed_move()
        {
            bed_move.controls.play();
        }
        internal static void Play_block_fall()
        {
            block_fall.controls.play();
        }
        internal static void Play_book_open()
        {
            book_open.controls.play();
        }
        internal static void Play_box_max()
        {
            box_max.controls.play();
        }
        internal static void Play_chain_cut()
        {
            chain_cut.controls.play();
        }
        internal static void Play_chain_move()
        {
            chain_move.controls.play();
        }
        internal static void Play_chain_set()
        {
            chain_set.controls.play();
        }
        internal static void Play_chair_move()
        {
            chair_move.controls.play();
        }
        internal static void Play_display_on()
        {
            display_on.controls.play();
        }
        internal static void Play_dool_fine()
        {
            dool_fine.controls.play();
        }
        internal static void Play_door_open()
        {
            door_open.controls.play();
        }
        internal static void Play_enddoor_open()
        {
            enddoor_open.controls.play();
        }
        internal static void Play_failed()
        {
            failed.controls.play();
        }
        internal static void Play_fall_key()
        {
            fall_key.controls.play();
        }
        internal static void Play_hidesafe_open()
        {
            hidesafe_open.controls.play();
        }
        internal static void Play_light_move()
        {
            light_move.controls.play();
        }
        internal static void Play_locker_open()
        {
            locker_open.controls.play();
        }
        internal static void Play_mato_put()
        {
            mato_put.controls.play();
        }
        internal static void Play_moneybox_open()
        {
            moneybox_open.controls.play();
        }
        internal static void Play_move()
        {
            move.controls.play();
        }
        internal static void Play_object_lie()
        {
            object_lie.controls.play();
        }
        internal static void Play_plate_set()
        {
            plate_set.controls.play();
        }
        internal static void Play_prison_open()
        {
            prison_open.controls.play();
        }
        internal static void Play_slide_door()
        {
            slide_door.controls.play();
        }
        internal static void Play_stair_discovery()
        {
            stair_discovery.controls.play();
        }
        internal static void Play_stairs_open()
        {
            stairs_open.controls.play();
        }
        internal static void Play_success()
        {
            success.controls.play();
        }
        internal static void switch_onf_spill()
        {
            switch_onf.controls.play();
        }
        internal static void Play_tower_disappear()
        {
            tower_disappear.controls.play();
        }
        internal static void Play_triangle_change()
        {
            triangle_change.controls.play();
        }
        internal static void Play_valve_set()
        {
            valve_set.controls.play();
        }
        internal static void Play_vase_break()
        {
            vase_break.controls.play();
        }
        internal static void Play_warning()
        {
            warning.controls.play();
        }
        internal static void Play_water_fall()
        {
            water_fall.controls.play();
        }
        internal static void Play_water_spill()
        {
            water_spill.controls.play();
        }
        internal static void Play_wood_put()
        {
            wood_put.controls.play();
        }
        internal static void Play_wood_fire()
        {
            wood_fire.controls.play();
        }
        internal static void Play_clean_wall()
        {
            clean_wall.controls.play();
        }
        internal static void Play_keyboard()
        {
            keyboard.controls.play();
        }
        /* bath_spill.URL = "bath_spill.mp3";//
             bed_move.URL="bed_move.mp3";//
             block_fall.URL="block_fall.mp3";//
             book_open.URL="book_open.mp3";//
             box_max.URL="box_max.mp3";//
             chain_cut.URL="chain_cut.mp3";//
             chain_move.URL="chain_move.mp3";//
             chain_set.URL="chain_set.mp3";//
             chair_move.URL="chair_move.mp3";//
             display_on.URL="display_on.mp3";//
             dool_fine.URL="dool_fine.mp3";//
             door_open.URL="door_open.mp3";//
             enddoor_open.URL="enddoor_open.mp3";//
             failed.URL="failed.mp3";//
             fall_key.URL="fall_key.mp3";//
             hidesafe_open.URL="hidesafe_open.mp3";//
             light_move.URL="light_move.mp3";//
             locker_open.URL="locker_open.mp3";//
             mato_put.URL="mato_put.mp3";//
             moneybox_open.URL="moneybox_open.mp3";//
             move.URL="move.mp3";//
             object_lie.URL="object_lie.mp3";//
             plate_set.URL="plate_set.mp3";//
             prison_open.URL="prison_open.mp3";//
             slide_door.URL="slide_door.mp3";//
             stair_discovery.URL="stair_discovery.mp3";//
             stairs_open.URL="stairs_open.mp3";//
             success.URL="success.mp3";//
             switch_onf.URL="switch_onf.mp3";//
             tower_disappear.URL="tower_disappear.mp3";//
             triangle_change.URL="triangle_change.mp3";//
             valve_set.URL="valve_set.mp3";//
             vase_break.URL="vase_break.mp3";//
             warning.URL="warning.mp3";//
             water_fall.URL="water_fall.mp3";//
             water_spill.URL="water_spill.mp3";//
             wood_put.URL="wood_put.mp3";//*/
    }
}
