﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPosition : MonoBehaviour
{
    static public List<Vector3> tutorial_game = new List<Vector3>();
    static public List<Vector3> first_game = new List<Vector3>();
    static public List<Vector3> second_game = new List<Vector3>();
    static public List<Vector3> third_game = new List<Vector3>();
    static public List<Vector3> fourth_game = new List<Vector3>();
    static public List<Vector3> fifth_game = new List<Vector3>();
    static public List<Vector3> sixth_game = new List<Vector3>();

    Vector3 tutorial_game_1 = new Vector3(29.5f,-1.5f,-2);
    Vector3 tutorial_game_2 = new Vector3(30.5f,-0.5f,-2);
    Vector3 tutorial_game_3 = new Vector3(31.5f,0.5f,-2);
    Vector3 tutorial_game_4 = new Vector3(32.5f,1.5f,-2);
    Vector3 tutorial_game_5 = new Vector3(33.5f,2.5f,-2);

    Vector3 first_game_1 = new Vector3(4.0f,-4.0f,-2);
    Vector3 first_game_2 = new Vector3(4.0f,-3.0f,-2);
    Vector3 first_game_3 = new Vector3(4.0f,-2.0f,-2);
    Vector3 first_game_4 = new Vector3(4.0f,-1.0f,-2);
    Vector3 first_game_5 = new Vector3(4.0f,0f,-2);
    Vector3 first_game_6 = new Vector3(6.0f,-4.0f,-2);
    Vector3 first_game_7 = new Vector3(6.0f,-3.0f,-2);
    Vector3 first_game_8 = new Vector3(6.0f,-2.0f,-2);
    Vector3 first_game_9 = new Vector3(6.0f,-1.0f,-2);
    Vector3 first_game_10 = new Vector3(6.0f,0f,-2);
    Vector3 first_game_11 = new Vector3(6.0f,1.0f,-2);
    Vector3 first_game_12 = new Vector3(8.0f,-4.0f,-2);
    Vector3 first_game_13 = new Vector3(8.0f,-3.0f,-2);
    Vector3 first_game_14 = new Vector3(8.0f,-2.0f,-2);
    Vector3 first_game_15 = new Vector3(8.0f,-1.0f,-2);
    Vector3 first_game_16 = new Vector3(8.0f,0f,-2);
    Vector3 first_game_17 = new Vector3(8.0f,1.0f,-2);
    Vector3 first_game_18 = new Vector3(8.0f,2.0f,-2);
    Vector3 first_game_19 = new Vector3(10.0f,-4.0f,-2);
    Vector3 first_game_20 = new Vector3(10.0f,-3.0f,-2);
    Vector3 first_game_21 = new Vector3(10.0f,-2.0f,-2);
    Vector3 first_game_22 = new Vector3(10.0f,-1.0f,-2);
    Vector3 first_game_23 = new Vector3(10.0f,0f,-2);
    Vector3 first_game_24 = new Vector3(10.0f,1.0f,-2);
    Vector3 first_game_25 = new Vector3(10.0f,2.0f,-2);
    Vector3 first_game_26 = new Vector3(10.0f,3.0f,-2);
    // first_game list
    // second_game list
    Vector3 second_game_1 = new Vector3(50.0f,-4.0f,-2);
    Vector3 second_game_2 = new Vector3(50.0f,-3.0f,-2);
    Vector3 second_game_3 = new Vector3(50.0f,-2.0f,-2);
    Vector3 second_game_4 = new Vector3(50.0f,-1.0f,-2);
    Vector3 second_game_5 = new Vector3(50.0f,0f,-2);
    Vector3 second_game_6 = new Vector3(50.0f,1.0f,-2);
    Vector3 second_game_7 = new Vector3(50.0f,2.0f,-2);
    Vector3 second_game_8 = new Vector3(52.0f,-4.0f,-2);
    Vector3 second_game_9 = new Vector3(52.0f,-3.0f,-2);
    Vector3 second_game_10 = new Vector3(52.0f,-2.0f,-2);
    Vector3 second_game_11 = new Vector3(52.0f,-1.0f,-2);
    Vector3 second_game_12 = new Vector3(52.0f,0f,-2);
    Vector3 second_game_13 = new Vector3(52.0f,1.0f,-2);
    Vector3 second_game_14 = new Vector3(52.0f,2.0f,-2);
    Vector3 second_game_15 = new Vector3(54.0f,-4.0f,-2);
    Vector3 second_game_16 = new Vector3(54.0f,-3.0f,-2);
    Vector3 second_game_17 = new Vector3(54.0f,-2.0f,-2);
    Vector3 second_game_18 = new Vector3(54.0f,-1.0f,-2);
    Vector3 second_game_19 = new Vector3(54.0f,0f,-2);
    Vector3 second_game_20 = new Vector3(54.0f,1.0f,-2);
    Vector3 second_game_21 = new Vector3(56.0f,-4.0f,-2);
    Vector3 second_game_22 = new Vector3(56.0f,-3.0f,-2);
    Vector3 second_game_23 = new Vector3(56.0f,-2.0f,-2);
    Vector3 second_game_24 = new Vector3(56.0f,-1.0f,-2);
    Vector3 second_game_25 = new Vector3(56.0f,0f,-2);
    Vector3 second_game_26 = new Vector3(58.0f,-4.0f,-2);
    Vector3 second_game_27 = new Vector3(58.0f,-3.0f,-2);
    Vector3 second_game_28 = new Vector3(58.0f,-2.0f,-2);
    Vector3 second_game_29 = new Vector3(58.0f,-1.0f,-2);
    // third_game_list
    Vector3 third_game_1 = new Vector3(81.0f,-4.0f,-2);
    Vector3 third_game_2 = new Vector3(81.0f,-3.0f,-2);
    Vector3 third_game_3 = new Vector3(81.0f,-2.0f,-2);
    Vector3 third_game_4 = new Vector3(81.0f,-1.0f,-2);
    Vector3 third_game_5 = new Vector3(81.0f,0f,-2);
    Vector3 third_game_6 = new Vector3(83.0f,-4.0f,-2);
    Vector3 third_game_7 = new Vector3(83.0f,-3.0f,-2);
    Vector3 third_game_8 = new Vector3(83.0f,-2.0f,-2);
    Vector3 third_game_9 = new Vector3(83.0f,-1.0f,-2);
    Vector3 third_game_10 = new Vector3(83.0f,0f,-2);
    Vector3 third_game_11 = new Vector3(85.0f,-4.0f,-2);
    Vector3 third_game_12 = new Vector3(85.0f,-3.0f,-2);
    Vector3 third_game_13 = new Vector3(85.0f,-2.0f,-2);
    Vector3 third_game_14 = new Vector3(85.0f,-1.0f,-2);
    Vector3 third_game_15 = new Vector3(85.0f,0f,-2);
    Vector3 third_game_16 = new Vector3(90.0f,-4.0f,-2);
    Vector3 third_game_17 = new Vector3(90.0f,-3.0f,-2);
    Vector3 third_game_18 = new Vector3(90.0f,-2.0f,-2);
    Vector3 third_game_19 = new Vector3(90.0f,-1.0f,-2);
    Vector3 third_game_20 = new Vector3(90.0f,0f,-2);
    Vector3 third_game_21 = new Vector3(90.0f,1.0f,-2);
    Vector3 third_game_22 = new Vector3(91.0f,-4.0f,-2);
    Vector3 third_game_23 = new Vector3(91.0f,-3.0f,-2);
    Vector3 third_game_24 = new Vector3(91.0f,-2.0f,-2);
    Vector3 third_game_25 = new Vector3(91.0f,-1.0f,-2);
    Vector3 third_game_26 = new Vector3(91.0f,0f,-2);
    Vector3 third_game_27 = new Vector3(91.0f,1.0f,-2);
    Vector3 third_game_28 = new Vector3(91.0f,2.0f,-2);
    Vector3 third_game_29 = new Vector3(95.0f,-4.0f,-2);
    Vector3 third_game_30 = new Vector3(95.0f,-3.0f,-2);
    Vector3 third_game_31 = new Vector3(95.0f,-2.0f,-2);
    Vector3 third_game_32 = new Vector3(95.0f,-1.0f,-2);
    Vector3 third_game_33 = new Vector3(95.0f,0f,-2);
    Vector3 third_game_34 = new Vector3(95.0f,1.0f,-2);
    Vector3 third_game_35 = new Vector3(95.0f,2.0f,-2);
    Vector3 third_game_36 = new Vector3(95.0f,3.0f,-2);
    Vector3 third_game_37 = new Vector3(95.0f,4.0f,-2);
    Vector3 third_game_38 = new Vector3(96.0f,-4.0f,-2);
    Vector3 third_game_39 = new Vector3(96.0f,-3.0f,-2);
    Vector3 third_game_40 = new Vector3(96.0f,-2.0f,-2);
    Vector3 third_game_41 = new Vector3(96.0f,-1.0f,-2);
    Vector3 third_game_42 = new Vector3(96.0f,0f,-2);
    Vector3 third_game_43 = new Vector3(96.0f,1.0f,-2);
    Vector3 third_game_44 = new Vector3(96.0f,2.0f,-2);
    Vector3 third_game_45 = new Vector3(96.0f,3.0f,-2);
    Vector3 third_game_46 = new Vector3(96.0f,4.0f,-2);
    // fourth game
    Vector3 fourth_game_1 = new Vector3(37.5f,-3.5f,-2);
    Vector3 fourth_game_2 = new Vector3(37.5f,-2.5f,-2);
    Vector3 fourth_game_3 = new Vector3(37.5f,-1.5f,-2);
    Vector3 fourth_game_4 = new Vector3(38.5f,-3.5f,-2);
    Vector3 fourth_game_5 = new Vector3(38.5f,-2.5f,-2);
    Vector3 fourth_game_6 = new Vector3(38.5f,-1.5f,-2);
    Vector3 fourth_game_7 = new Vector3(39.5f,-3.5f,-2);
    Vector3 fourth_game_8 = new Vector3(39.5f,-2.5f,-2);
    Vector3 fourth_game_9 = new Vector3(39.5f,-1.5f,-2);
    Vector3 fourth_game_10 = new Vector3(48.5f,-3.5f,-2);
    Vector3 fourth_game_11 = new Vector3(48.5f,-2.5f,-2);
    Vector3 fourth_game_12 = new Vector3(48.5f,-1.5f,-2);
    Vector3 fourth_game_13 = new Vector3(49.5f,-3.5f,-2);
    Vector3 fourth_game_14 = new Vector3(49.5f,-2.5f,-2);
    Vector3 fourth_game_15 = new Vector3(49.5f,-1.5f,-2);
    Vector3 fourth_game_16 = new Vector3(50.5f,-3.5f,-2);
    Vector3 fourth_game_17 = new Vector3(50.5f,-2.5f,-2);
    Vector3 fourth_game_18 = new Vector3(50.5f,-1.5f,-2);

    Vector3 fifth_game_1 = new Vector3(128.5f,-4.5f,-2);
    Vector3 fifth_game_2 = new Vector3(128.5f,-3.5f,-2);
    Vector3 fifth_game_3 = new Vector3(128.5f,-2.5f,-2);
    Vector3 fifth_game_4 = new Vector3(129.5f,-4.5f,-2);
    Vector3 fifth_game_5 = new Vector3(129.5f,-3.5f,-2);
    Vector3 fifth_game_6 = new Vector3(129.5f,-2.5f,-2);
    Vector3 fifth_game_7 = new Vector3(130.5f,-4.5f,-2);
    Vector3 fifth_game_8 = new Vector3(130.5f,-3.5f,-2);
    Vector3 fifth_game_9 = new Vector3(130.5f,-2.5f,-2);
    Vector3 fifth_game_10 = new Vector3(139.5f,-4.5f,-2);
    Vector3 fifth_game_11 = new Vector3(139.5f,-3.5f,-2);
    Vector3 fifth_game_12 = new Vector3(139.5f,-2.5f,-2);
    Vector3 fifth_game_13 = new Vector3(140.5f,-4.5f,-2);
    Vector3 fifth_game_14 = new Vector3(140.5f,-3.5f,-2);
    Vector3 fifth_game_15 = new Vector3(140.5f,-2.5f,-2);
    Vector3 fifth_game_16 = new Vector3(141.5f,-4.5f,-2);
    Vector3 fifth_game_17 = new Vector3(141.5f,-3.5f,-2);
    Vector3 fifth_game_18 = new Vector3(141.5f,-2.5f,-2);

    Vector3 sixth_game_1 = new Vector3(171.5f,-4.5f,-2);
    Vector3 sixth_game_2 = new Vector3(172.5f,-4.5f,-2);
    Vector3 sixth_game_3 = new Vector3(172.5f,-3.5f,-2);
    Vector3 sixth_game_4 = new Vector3(174.5f,-3.5f,-2);
    Vector3 sixth_game_5 = new Vector3(175.5f,-3.5f,-2);
    Vector3 sixth_game_6 = new Vector3(175.5f,-2.5f,-2);
    Vector3 sixth_game_7 = new Vector3(177.5f,-2.5f,-2);
    Vector3 sixth_game_8 = new Vector3(178.5f,-2.5f,-2);
    Vector3 sixth_game_9 = new Vector3(178.5f,-1.5f,-2);
    Vector3 sixth_game_10 = new Vector3(180.5f,-1.5f,-2);
    Vector3 sixth_game_11 = new Vector3(181.5f,-1.5f,-2);
    Vector3 sixth_game_12 = new Vector3(181.5f,-0.5f,-2);

    void Start()
    {
        tutorial_game.Add(tutorial_game_1);
        tutorial_game.Add(tutorial_game_2);
        tutorial_game.Add(tutorial_game_3);
        tutorial_game.Add(tutorial_game_4);
        tutorial_game.Add(tutorial_game_5);

        first_game.Add(first_game_1);
        first_game.Add(first_game_2);
        first_game.Add(first_game_3);
        first_game.Add(first_game_4);
        first_game.Add(first_game_5);
        first_game.Add(first_game_6);
        first_game.Add(first_game_7);
        first_game.Add(first_game_8);
        first_game.Add(first_game_9);
        first_game.Add(first_game_10);
        first_game.Add(first_game_11);
        first_game.Add(first_game_12);
        first_game.Add(first_game_13);
        first_game.Add(first_game_14);
        first_game.Add(first_game_15);
        first_game.Add(first_game_16);
        first_game.Add(first_game_17);
        first_game.Add(first_game_18);
        first_game.Add(first_game_19);
        first_game.Add(first_game_20);
        first_game.Add(first_game_21);
        first_game.Add(first_game_22);
        first_game.Add(first_game_23);
        first_game.Add(first_game_24);
        first_game.Add(first_game_25);
        first_game.Add(first_game_26);

        second_game.Add(second_game_1);
        second_game.Add(second_game_2);
        second_game.Add(second_game_3);
        second_game.Add(second_game_4);
        second_game.Add(second_game_5);
        second_game.Add(second_game_6);
        second_game.Add(second_game_7);
        second_game.Add(second_game_8);
        second_game.Add(second_game_9);
        second_game.Add(second_game_10);
        second_game.Add(second_game_11);
        second_game.Add(second_game_12);
        second_game.Add(second_game_13);
        second_game.Add(second_game_14);
        second_game.Add(second_game_15);
        second_game.Add(second_game_16);
        second_game.Add(second_game_17);
        second_game.Add(second_game_18);
        second_game.Add(second_game_19);
        second_game.Add(second_game_20);
        second_game.Add(second_game_21);
        second_game.Add(second_game_22);
        second_game.Add(second_game_23);
        second_game.Add(second_game_24);
        second_game.Add(second_game_25);
        second_game.Add(second_game_26);
        second_game.Add(second_game_27);
        second_game.Add(second_game_28);
        second_game.Add(second_game_29);

        third_game.Add(third_game_1);
        third_game.Add(third_game_2);
        third_game.Add(third_game_3);
        third_game.Add(third_game_4);
        third_game.Add(third_game_5);
        third_game.Add(third_game_6);
        third_game.Add(third_game_7);
        third_game.Add(third_game_8);
        third_game.Add(third_game_9);
        third_game.Add(third_game_10);
        third_game.Add(third_game_11);
        third_game.Add(third_game_12);
        third_game.Add(third_game_13);
        third_game.Add(third_game_14);
        third_game.Add(third_game_15);
        third_game.Add(third_game_16);
        third_game.Add(third_game_17);
        third_game.Add(third_game_18);
        third_game.Add(third_game_19);
        third_game.Add(third_game_20);
        third_game.Add(third_game_21);
        third_game.Add(third_game_22);
        third_game.Add(third_game_23);
        third_game.Add(third_game_24);
        third_game.Add(third_game_25);
        third_game.Add(third_game_26);
        third_game.Add(third_game_27);
        third_game.Add(third_game_28);
        third_game.Add(third_game_29);
        third_game.Add(third_game_30);
        third_game.Add(third_game_31);
        third_game.Add(third_game_32);
        third_game.Add(third_game_33);
        third_game.Add(third_game_34);
        third_game.Add(third_game_35);
        third_game.Add(third_game_36);
        third_game.Add(third_game_37);
        third_game.Add(third_game_38);
        third_game.Add(third_game_39);
        third_game.Add(third_game_40);
        third_game.Add(third_game_41);
        third_game.Add(third_game_42);
        third_game.Add(third_game_43);
        third_game.Add(third_game_44);
        third_game.Add(third_game_45);
        third_game.Add(third_game_46);

        fourth_game.Add(fourth_game_1);
        fourth_game.Add(fourth_game_2);
        fourth_game.Add(fourth_game_3);
        fourth_game.Add(fourth_game_4);
        fourth_game.Add(fourth_game_5);
        fourth_game.Add(fourth_game_6);
        fourth_game.Add(fourth_game_7);
        fourth_game.Add(fourth_game_8);
        fourth_game.Add(fourth_game_9);
        fourth_game.Add(fourth_game_10);
        fourth_game.Add(fourth_game_11);
        fourth_game.Add(fourth_game_12);
        fourth_game.Add(fourth_game_13);
        fourth_game.Add(fourth_game_14);
        fourth_game.Add(fourth_game_15);
        fourth_game.Add(fourth_game_16);
        fourth_game.Add(fourth_game_17);
        fourth_game.Add(fourth_game_18);

        fifth_game.Add(fifth_game_1);
        fifth_game.Add(fifth_game_2);
        fifth_game.Add(fifth_game_3);
        fifth_game.Add(fifth_game_4);
        fifth_game.Add(fifth_game_5);
        fifth_game.Add(fifth_game_6);
        fifth_game.Add(fifth_game_7);
        fifth_game.Add(fifth_game_8);
        fifth_game.Add(fifth_game_9);
        fifth_game.Add(fifth_game_10);
        fifth_game.Add(fifth_game_11);
        fifth_game.Add(fifth_game_12);
        fifth_game.Add(fifth_game_13);
        fifth_game.Add(fifth_game_14);
        fifth_game.Add(fifth_game_15);
        fifth_game.Add(fifth_game_16);
        fifth_game.Add(fifth_game_17);
        fifth_game.Add(fifth_game_18);
    
        sixth_game.Add(sixth_game_1);
        sixth_game.Add(sixth_game_2);
        sixth_game.Add(sixth_game_3);
        sixth_game.Add(sixth_game_4);
        sixth_game.Add(sixth_game_5);
        sixth_game.Add(sixth_game_6);
        sixth_game.Add(sixth_game_7);
        sixth_game.Add(sixth_game_8);
        sixth_game.Add(sixth_game_9);
        sixth_game.Add(sixth_game_10);
        sixth_game.Add(sixth_game_11);
        sixth_game.Add(sixth_game_12);
        
    }
}