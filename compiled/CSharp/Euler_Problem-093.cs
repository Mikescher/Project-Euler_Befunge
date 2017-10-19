/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADtmk2PozgQhv+KQ3ouQUxjlwPpqIVW2sveZo9zGKUvK3H1Kafe/z4FzoexjTHd4Am0LUWNoZqXx1UUL1HO5CcOQsg2wEAZ0oqFk7uMUHJ/B5X7gWO9"+
                                    "iynpfkS5BcqFvu+iXJSLclEuykW5KBdK7rqPGEM9GuW85dwjyk0o56GpRXxJOXVfNyDKfVhuxFio3NhriHIWuU50J8pT13JiT7lu1Brk9H2jEhjlPnXSKBflliS37Y4o"+
                                    "tzq5ySSj3B+VM2P1SMuRKPfV5MxYQ8oaatnzteXmGFEuykW5LyCXh5VjYeVoWDkRVi4JK/dPWDnHdyhzyAVezN2q7ztY9X0XuGcGXsx198zAo0r+/zfZVTQ7JiT5dUz+"+
                                    "S87zi74fxTMq/UpfvpHXOYValieUqHj9neEH8MPx89cschVluahYXtMU8rZuKmgm/DLhzWR/mZDkZ0Iwdr9PdxiF+9tNno9LwHtWipwdU1rn7PU9O4gc2gng5EXkvJ1w"+
                                    "nOyzvcj37XQvKOBfCiKt/RPQXlcTfa3Sk/qv/ZMPjooAXmK22Z7eGG6kjCIaFaPW2La8dVrjymdjVvlDa9xdgjdN7+SQ81vW7hpXrhPKcRZFmYuC72pgTQ0UILe4KJjc"+
                                    "AlFQucV6z1LJ7J+6rcqSb88FfvWKc0VJ7aos6iNNy0K4T1iVZRtXOuOq8tBGHcyoE1Ym2eLu7bGZbgdLHWMx1BEnU3duT2eLOmf07SnHK6ZFzYo6paUA3CoFL2ooRedU"+
                                    "l9iDoCVGYOxBAG4dLFH0gPsx4qVz7Eyqo2/uiGesM0qlA0nHfOhA0jEnXfZIdFylAwcdokkyxEytdIhGH4kO0SQZYqYDdPRKB310Mnc7BvWzQvhHcyfpQNK5KpO1dODO"+
                                    "3WZ7fmsgASEPEnJeuko7crLRcd/cgewtBh15anPX0DFJR2ejOymt0kV3q0xJ1tTnQM/M7D2T2Juz/xWPjn1PN5tvzeP4hW42WU3Zs5y86rnjVzo2QAeSztIzifIaF4aO"+
                                    "9h4xK1PScRed2jMzC139+SseE+tBBwodH67MW8+00aWfv+Ixsf2louXu5lOclan2TBtd/2LOQid6j1grk8vnglfPtNE5vPYcdHnvEc1nZiN8pnxW633zMe876TOzET7z"+
                                    "SscMOv75Kx4T61eZXKXz9Zkto0YX+IngUZmqz8xG+EwbXeDK7L/NrT4zG+EzbXQBKlP0bHeH1Wf65Q7uvSU83Ynz5lsSTqDO+42fw2dmVjoEavzxtXU2bwCl2jrd3+N8"+
                                    "jE73x8o1uU/h8Jm+dFCqrfOR6VSfOUh3a53tW04pC/Qx6Uyf6ZO7Ox08NJ3pMwfpbq3z8XNn+kyTrnnrNnIH994yJZ3rrVuNcg7NZ0p3Zfeaw99qD48xuZtgaD7zSmfz"+
                                    "mgun4zodrIZO9ZnSf6yJTvWZV7pVVebNZ64vd6bPbBlXQmf6zPXRqT5zTXSmz1wTnekz10en+sy10CGTdMbSbjaeuDDt5rR0/c5YjinUJB0YdFCYdnOpdNyg44VpN5dK"+
                                    "R+9094d680ZaqJZlqXTdyrzTQaHazaXS8R46vorcWStTdsxLfS6Zjum54yodWzidtTJvdHzhdEplanZzlZUJKt2SK7P5jtL6RLjRwXR0yikq7Rf1+q8wJ6GrEpLYf2ks"+
                                    "Jjl/d/wGS+iz/X1bAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<111&&y<211)?g[y*111+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<111&&y<211)g[y*111+x]=v;}
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0;
        gw(2,1,0);
        gw(2,3,2520);
        gw(3,1,0);
        gw(108,99,32);
        sa(9999);
        sa(9999);
    _1:
        if(sp()!=0)goto _205;else goto _2;
    _2:
        gw(2,0,1);
        sp();
    _3:
        gw(3,0,gr(2,0)+1);
    _4:
        gw(4,0,gr(3,0)+1);
    _5:
        gw(5,0,gr(4,0)+1);
    _6:
        gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),88);
        gw(3,1,gr(3,1)+1);
        t0=gr(5,0)-9;
        gw(5,0,gr(5,0)+1);
        if((t0)!=0)goto _6;else goto _8;
    _8:
        t0=gr(4,0)-8;
        gw(4,0,gr(4,0)+1);

        if((t0)!=0)goto _5;else goto _9;
    _9:
        t0=gr(3,0)-7;
        gw(3,0,gr(3,0)+1);

        if((t0)!=0)goto _4;else goto _10;
    _10:
        t0=gr(2,0)-6;
        gw(2,0,gr(2,0)+1);

        if((t0)!=0)goto _3;else goto _11;
    _11:
        if(gr(3,1)!=1)goto _13;else goto _12;
    _12:
        System.Console.Out.Write(gr(1,4)+" ");
        System.Console.Out.Write(gr(2,4)+" ");
        System.Console.Out.Write(gr(3,4)+" ");
        System.Console.Out.Write(gr(4,4)+" ");
        return;
    _13:
        gw(2,1,gr(2,1)+1);
        gw(3,1,0);
        gw(2,0,1);
    _14:
        gw(3,0,gr(2,0)+1);
    _15:
        gw(4,0,gr(3,0)+1);
    _16:
        gw(5,0,gr(4,0)+1);
    _17:
        if(gr((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0))!=88)goto _18;else goto _22;
    _18:
        t0=gr(5,0)-9;
        gw(5,0,gr(5,0)+1);

        if((t0)!=0)goto _17;else goto _19;
    _19:
        t0=gr(4,0)-8;
        gw(4,0,gr(4,0)+1);

        if((t0)!=0)goto _16;else goto _20;
    _20:
        t0=gr(3,0)-7;
        gw(3,0,gr(3,0)+1);

        if((t0)!=0)goto _15;else goto _21;
    _21:
        t0=gr(2,0)-6;
        gw(2,0,gr(2,0)+1);

        if((t0)!=0)goto _14;else goto _11;
    _22:
        gw(1,6,gr(2,0)*gr(2,3));
        gw(2,6,gr(3,0)*gr(2,3));
        gw(3,6,gr(4,0)*gr(2,3));
        gw(4,6,gr(5,0)*gr(2,3));
        gw(7,6,0);
    _23:
        t0=gr(7,6);
        sa(gr(7,6));
        gw(7,6,gr(7,6)+1);

        if((t0)!=0)goto _24;else goto _204;
    _24:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _25;else goto _203;
    _25:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _26;else goto _202;
    _26:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _27;else goto _201;
    _27:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _28;else goto _200;
    _28:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _29;else goto _199;
    _29:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _30;else goto _198;
    _30:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _31;else goto _197;
    _31:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _32;else goto _196;
    _32:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _33;else goto _195;
    _33:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _34;else goto _194;
    _34:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _35;else goto _193;
    _35:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _36;else goto _192;
    _36:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _37;else goto _191;
    _37:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _38;else goto _190;
    _38:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _39;else goto _189;
    _39:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _40;else goto _188;
    _40:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _41;else goto _187;
    _41:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _42;else goto _186;
    _42:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _43;else goto _185;
    _43:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _44;else goto _184;
    _44:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _45;else goto _183;
    _45:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _46;else goto _182;
    _46:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _47;else goto _181;
    _47:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _48;else goto _180;
    _48:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _49;else goto _179;
    _49:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _50;else goto _178;
    _50:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _51;else goto _177;
    _51:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _52;else goto _176;
    _52:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _53;else goto _175;
    _53:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _54;else goto _174;
    _54:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _55;else goto _173;
    _55:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _56;else goto _172;
    _56:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _57;else goto _171;
    _57:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _58;else goto _170;
    _58:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _59;else goto _169;
    _59:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _60;else goto _167;
    _60:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _61;else goto _165;
    _61:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _62;else goto _163;
    _62:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _63;else goto _161;
    _63:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _64;else goto _159;
    _64:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _65;else goto _157;
    _65:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _66;else goto _155;
    _66:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _67;else goto _153;
    _67:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _68;else goto _151;
    _68:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _69;else goto _149;
    _69:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _70;else goto _147;
    _70:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _146;else goto _71;
    _71:
        sp();

        if((gr(3,6))!=0)goto _72;else goto _23;
    _72:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6));
        gw(3,7,td(gr(4,6)*gr(2,3),gr(3,6)));
    _73:
        t0=gr(7,7);
        sa(gr(7,7));
        gw(7,7,gr(7,7)+1);

        if((t0)!=0)goto _74;else goto _145;
    _74:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _75;else goto _144;
    _75:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _76;else goto _143;
    _76:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _77;else goto _142;
    _77:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _78;else goto _141;
    _78:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _79;else goto _140;
    _79:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _80;else goto _139;
    _80:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _81;else goto _138;
    _81:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _82;else goto _137;
    _82:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _83;else goto _136;
    _83:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _84;else goto _135;
    _84:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _85;else goto _134;
    _85:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _86;else goto _133;
    _86:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _87;else goto _132;
    _87:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _88;else goto _131;
    _88:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _89;else goto _130;
    _89:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _90;else goto _129;
    _90:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _91;else goto _128;
    _91:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _92;else goto _126;
    _92:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _93;else goto _124;
    _93:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _94;else goto _122;
    _94:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _95;else goto _120;
    _95:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _96;else goto _118;
    _96:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _117;else goto _97;
    _97:
        sp();

        if((gr(2,7))!=0)goto _99;else goto _98;
    _98:
        sa(4);
        goto _73;
    _99:
        gw(7,8,0);
        gw(1,8,gr(1,7));
        gw(2,8,td(gr(3,7)*gr(2,3),gr(2,7)));
    _100:
        t0=gr(7,8);
        sa(gr(7,8));
        gw(7,8,gr(7,8)+1);

        if((t0)!=0)goto _101;else goto _116;
    _101:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _102;else goto _115;
    _102:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _103;else goto _114;
    _103:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _104;else goto _113;
    _104:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _109;else goto _105;
    _105:
        sp();

        if((gr(2,8))!=0)goto _106;else goto _100;
    _106:
        gw(1,9,td(gr(1,8)*gr(2,3),gr(2,8)));
    _107:
        if(((((td(gr(1,9),gr(2,3)))-gr(2,1)!=0)?1:0)+((tm(gr(1,9),gr(2,3))!=0)?1L:0L))!=0)goto _100;else goto _108;
    _108:
        gw(3,1,gr(3,1)+1);
        gw(1,4,gr(2,0));
        gw(2,4,gr(3,0));
        gw(3,4,gr(4,0));
        gw(4,4,gr(5,0));
        goto _18;
    _109:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _112;else goto _110;
    _110:
        sp();

        if((gr(1,8))!=0)goto _111;else goto _100;
    _111:
        gw(1,9,td(gr(2,8)*gr(2,3),gr(1,8)));
        goto _107;
    _112:
        sp();
        goto _73;
    _113:
        gw(1,9,td(gr(1,8)*gr(2,8),gr(2,3)));
        sp();
        goto _107;
    _114:
        gw(1,9,gr(2,8)-gr(1,8));
        sp();
        goto _107;
    _115:
        gw(1,9,gr(1,8)-gr(2,8));
        sp();
        goto _107;
    _116:
        gw(1,9,gr(1,8)+gr(2,8));
        sp();
        goto _107;
    _117:
        sp();
        goto _23;
    _118:
        sp();

        if((gr(2,7))!=0)goto _119;else goto _98;
    _119:
        gw(7,8,0);
        gw(1,8,gr(2,7));
        gw(2,8,td(gr(3,7)*gr(2,3),gr(1,7)));
        goto _100;
    _120:
        sp();

        if((gr(2,7))!=0)goto _121;else goto _98;
    _121:
        gw(7,8,0);
        gw(1,8,gr(1,7));
        gw(2,8,td(gr(2,7)*gr(2,3),gr(3,7)));
        goto _100;
    _122:
        sp();

        if((gr(2,7))!=0)goto _123;else goto _98;
    _123:
        gw(7,8,0);
        gw(1,8,gr(3,7));
        gw(2,8,td(gr(2,7)*gr(2,3),gr(1,7)));
        goto _100;
    _124:
        sp();

        if((gr(2,7))!=0)goto _125;else goto _98;
    _125:
        gw(7,8,0);
        gw(1,8,td(gr(1,7)*gr(2,3),gr(3,7)));
        gw(2,8,gr(2,7));
        goto _100;
    _126:
        sp();

        if((gr(2,7))!=0)goto _127;else goto _98;
    _127:
        gw(7,8,0);
        gw(1,8,td(gr(1,7)*gr(2,3),gr(2,7)));
        gw(2,8,gr(3,7));
        goto _100;
    _128:
        gw(7,8,0);
        gw(1,8,gr(1,7));
        gw(2,8,td(gr(3,7)*gr(2,7),gr(2,3)));
        sp();
        goto _100;
    _129:
        gw(7,8,0);
        gw(1,8,gr(2,7));
        gw(2,8,td(gr(3,7)*gr(1,7),gr(2,3)));
        sp();
        goto _100;
    _130:
        gw(7,8,0);
        gw(1,8,gr(1,7));
        gw(2,8,td(gr(2,7)*gr(3,7),gr(2,3)));
        sp();
        goto _100;
    _131:
        gw(7,8,0);
        gw(1,8,gr(3,7));
        gw(2,8,td(gr(2,7)*gr(1,7),gr(2,3)));
        sp();
        goto _100;
    _132:
        gw(7,8,0);
        gw(1,8,td(gr(1,7)*gr(3,7),gr(2,3)));
        gw(2,8,gr(2,7));
        sp();
        goto _100;
    _133:
        gw(7,8,0);
        gw(1,8,td(gr(1,7)*gr(2,7),gr(2,3)));
        gw(2,8,gr(3,7));
        sp();
        goto _100;
    _134:
        gw(7,8,0);
        gw(1,8,gr(1,7));
        gw(2,8,gr(3,7)-gr(2,7));
        sp();
        goto _100;
    _135:
        gw(7,8,0);
        gw(1,8,gr(2,7));
        gw(2,8,gr(3,7)-gr(1,7));
        sp();
        goto _100;
    _136:
        gw(7,8,0);
        gw(1,8,gr(1,7));
        gw(2,8,gr(2,7)-gr(3,7));
        sp();
        goto _100;
    _137:
        gw(7,8,0);
        gw(1,8,gr(3,7));
        gw(2,8,gr(2,7)-gr(1,7));
        sp();
        goto _100;
    _138:
        gw(7,8,0);
        gw(1,8,gr(1,7)-gr(3,7));
        gw(2,8,gr(2,7));
        sp();
        goto _100;
    _139:
        gw(7,8,0);
        gw(1,8,gr(1,7)-gr(2,7));
        gw(2,8,gr(3,7));
        sp();
        goto _100;
    _140:
        gw(7,8,0);
        gw(1,8,gr(1,7));
        gw(2,8,gr(3,7)+gr(2,7));
        sp();
        goto _100;
    _141:
        gw(7,8,0);
        gw(1,8,gr(2,7));
        gw(2,8,gr(3,7)+gr(1,7));
        sp();
        goto _100;
    _142:
        gw(7,8,0);
        gw(1,8,gr(1,7));
        gw(2,8,gr(2,7)+gr(3,7));
        sp();
        goto _100;
    _143:
        gw(7,8,0);
        gw(1,8,gr(3,7));
        gw(2,8,gr(2,7)+gr(1,7));
        sp();
        goto _100;
    _144:
        gw(7,8,0);
        gw(1,8,gr(1,7)+gr(3,7));
        gw(2,8,gr(2,7));
        sp();
        goto _100;
    _145:
        gw(7,8,0);
        gw(1,8,gr(1,7)+gr(2,7));
        gw(2,8,gr(3,7));
        sp();
        goto _100;
    _146:
        gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),32);
        sp();
        goto _18;
    _147:
        sp();

        if((gr(2,6))!=0)goto _148;else goto _23;
    _148:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(3,6));
        gw(3,7,td(gr(4,6)*gr(2,3),gr(2,6)));
        goto _73;
    _149:
        sp();

        if((gr(1,6))!=0)goto _150;else goto _23;
    _150:
        gw(7,7,0);
        gw(1,7,gr(3,6));
        gw(2,7,gr(2,6));
        gw(3,7,td(gr(4,6)*gr(2,3),gr(1,6)));
        goto _73;
    _151:
        sp();

        if((gr(4,6))!=0)goto _152;else goto _23;
    _152:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6));
        gw(3,7,td(gr(3,6)*gr(2,3),gr(4,6)));
        goto _73;
    _153:
        sp();

        if((gr(2,6))!=0)goto _154;else goto _23;
    _154:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(4,6));
        gw(3,7,td(gr(3,6)*gr(2,3),gr(2,6)));
        goto _73;
    _155:
        sp();

        if((gr(1,6))!=0)goto _156;else goto _23;
    _156:
        gw(7,7,0);
        gw(1,7,gr(4,6));
        gw(2,7,gr(2,6));
        gw(3,7,td(gr(3,6)*gr(2,3),gr(1,6)));
        goto _73;
    _157:
        sp();

        if((gr(4,6))!=0)goto _158;else goto _23;
    _158:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,td(gr(2,6)*gr(2,3),gr(4,6)));
        gw(3,7,gr(3,6));
        goto _73;
    _159:
        sp();

        if((gr(3,6))!=0)goto _160;else goto _23;
    _160:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,td(gr(2,6)*gr(2,3),gr(3,6)));
        gw(3,7,gr(4,6));
        goto _73;
    _161:
        sp();

        if((gr(1,6))!=0)goto _162;else goto _23;
    _162:
        gw(7,7,0);
        gw(1,7,gr(4,6));
        gw(2,7,td(gr(2,6)*gr(2,3),gr(1,6)));
        gw(3,7,gr(3,6));
        goto _73;
    _163:
        sp();

        if((gr(4,6))!=0)goto _164;else goto _23;
    _164:
        gw(7,7,0);
        gw(1,7,td(gr(1,6)*gr(2,3),gr(4,6)));
        gw(2,7,gr(2,6));
        gw(3,7,gr(3,6));
        goto _73;
    _165:
        sp();

        if((gr(3,6))!=0)goto _166;else goto _23;
    _166:
        gw(7,7,0);
        gw(1,7,td(gr(1,6)*gr(2,3),gr(3,6)));
        gw(2,7,gr(2,6));
        gw(3,7,gr(4,6));
        goto _73;
    _167:
        sp();

        if((gr(2,6))!=0)goto _168;else goto _23;
    _168:
        gw(7,7,0);
        gw(1,7,td(gr(1,6)*gr(2,3),gr(2,6)));
        gw(2,7,gr(3,6));
        gw(3,7,gr(4,6));
        goto _73;
    _169:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6));
        gw(3,7,td(gr(4,6)*gr(3,6),gr(2,3)));
        sp();
        goto _73;
    _170:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(3,6));
        gw(3,7,td(gr(4,6)*gr(2,6),gr(2,3)));
        sp();
        goto _73;
    _171:
        gw(7,7,0);
        gw(1,7,gr(3,6));
        gw(2,7,gr(2,6));
        gw(3,7,td(gr(4,6)*gr(1,6),gr(2,3)));
        sp();
        goto _73;
    _172:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6));
        gw(3,7,td(gr(3,6)*gr(4,6),gr(2,3)));
        sp();
        goto _73;
    _173:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(4,6));
        gw(3,7,td(gr(3,6)*gr(2,6),gr(2,3)));
        sp();
        goto _73;
    _174:
        gw(7,7,0);
        gw(1,7,gr(4,6));
        gw(2,7,gr(2,6));
        gw(3,7,td(gr(3,6)*gr(1,6),gr(2,3)));
        sp();
        goto _73;
    _175:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,td(gr(2,6)*gr(4,6),gr(2,3)));
        gw(3,7,gr(3,6));
        sp();
        goto _73;
    _176:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,td(gr(2,6)*gr(3,6),gr(2,3)));
        gw(3,7,gr(4,6));
        sp();
        goto _73;
    _177:
        gw(7,7,0);
        gw(1,7,gr(4,6));
        gw(2,7,td(gr(2,6)*gr(1,6),gr(2,3)));
        gw(3,7,gr(3,6));
        sp();
        goto _73;
    _178:
        gw(7,7,0);
        gw(1,7,td(gr(1,6)*gr(4,6),gr(2,3)));
        gw(2,7,gr(2,6));
        gw(3,7,gr(3,6));
        sp();
        goto _73;
    _179:
        gw(7,7,0);
        gw(1,7,td(gr(1,6)*gr(3,6),gr(2,3)));
        gw(2,7,gr(2,6));
        gw(3,7,gr(4,6));
        sp();
        goto _73;
    _180:
        gw(7,7,0);
        gw(1,7,td(gr(1,6)*gr(2,6),gr(2,3)));
        gw(2,7,gr(3,6));
        gw(3,7,gr(4,6));
        sp();
        goto _73;
    _181:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(4,6)-gr(3,6));
        sp();
        goto _73;
    _182:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(3,6));
        gw(3,7,gr(4,6)-gr(2,6));
        sp();
        goto _73;
    _183:
        gw(7,7,0);
        gw(1,7,gr(3,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(4,6)-gr(1,6));
        sp();
        goto _73;
    _184:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(3,6)-gr(4,6));
        sp();
        goto _73;
    _185:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(4,6));
        gw(3,7,gr(3,6)-gr(2,6));
        sp();
        goto _73;
    _186:
        gw(7,7,0);
        gw(1,7,gr(4,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(3,6)-gr(1,6));
        sp();
        goto _73;
    _187:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6)-gr(4,6));
        gw(3,7,gr(3,6));
        sp();
        goto _73;
    _188:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6)-gr(3,6));
        gw(3,7,gr(4,6));
        sp();
        goto _73;
    _189:
        gw(7,7,0);
        gw(1,7,gr(4,6));
        gw(2,7,gr(2,6)-gr(1,6));
        gw(3,7,gr(3,6));
        sp();
        goto _73;
    _190:
        gw(7,7,0);
        gw(1,7,gr(1,6)-gr(4,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(3,6));
        sp();
        goto _73;
    _191:
        gw(7,7,0);
        gw(1,7,gr(1,6)-gr(3,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(4,6));
        sp();
        goto _73;
    _192:
        gw(7,7,0);
        gw(1,7,gr(1,6)-gr(2,6));
        gw(2,7,gr(3,6));
        gw(3,7,gr(4,6));
        sp();
        goto _73;
    _193:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(4,6)+gr(3,6));
        sp();
        goto _73;
    _194:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(3,6));
        gw(3,7,gr(4,6)+gr(2,6));
        sp();
        goto _73;
    _195:
        gw(7,7,0);
        gw(1,7,gr(3,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(4,6)+gr(1,6));
        sp();
        goto _73;
    _196:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(3,6)+gr(4,6));
        sp();
        goto _73;
    _197:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(4,6));
        gw(3,7,gr(3,6)+gr(2,6));
        sp();
        goto _73;
    _198:
        gw(7,7,0);
        gw(1,7,gr(4,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(3,6)+gr(1,6));
        sp();
        goto _73;
    _199:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6)+gr(4,6));
        gw(3,7,gr(3,6));
        sp();
        goto _73;
    _200:
        gw(7,7,0);
        gw(1,7,gr(1,6));
        gw(2,7,gr(2,6)+gr(3,6));
        gw(3,7,gr(4,6));
        sp();
        goto _73;
    _201:
        gw(7,7,0);
        gw(1,7,gr(4,6));
        gw(2,7,gr(2,6)+gr(1,6));
        gw(3,7,gr(3,6));
        sp();
        goto _73;
    _202:
        gw(7,7,0);
        gw(1,7,gr(1,6)+gr(4,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(3,6));
        sp();
        goto _73;
    _203:
        gw(7,7,0);
        gw(1,7,gr(1,6)+gr(3,6));
        gw(2,7,gr(2,6));
        gw(3,7,gr(4,6));
        sp();
        goto _73;
    _204:
        gw(7,7,0);
        gw(1,7,gr(1,6)+gr(2,6));
        gw(2,7,gr(3,6));
        gw(3,7,gr(4,6));
        sp();
        goto _73;
    _205:
        sa(sp()-1L);

        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sr()%100)+9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/100L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _1;
}
}
