/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABACtVsuS4yoM/RWl4tlAexpBnHQoiprPuAuKZMeWFSt//EjCSRx3d2burUuVEz9k6ejoSLj9Qyvi2PaPBetzAD7+zTLs0gDg/+fSsksk1//VZRysLait"+
                                    "rdD6Hccux4bhr11GKO/JnRR5KdXv5kj3vG3WL4YhVjSY40i//Tifob10mQ2WYq1WJ+f9iAFATS5gS8W5H9WFsV3afjzRI18MhmpQ62fEf+QyEzCoNfrdvl28yxj3gzxA"+
                                    "U03Ni9X3LmNBLO3J5WWgaxPnziuWzP+Hs5r0QUVvkneT+rFNPBaP+mDqNLYifnH0TCbaUpLPjXLPTACzSu6bw2psaL6+MyeJKdomns2hjljMIRxtO030Mpl3OkNDcsbZ"+
                                    "hUcmhovvKXCaF1HgJ5TXneIaNzWiikNu9H4khGNyOZbYy92XOG7GUBjPuEk9dLqHTyiZQMKoT5DDvCOZuBOIiBZaV+UWVP6sTXGmeGuKAmeqeqafTNKBHjV1mCCO4D3T"+
                                    "l5EpSj3dVbn5ch71NCWNPmmSESTSEaWFVI1oIr2Oyc+ksQThahSXgRgfCGtns7t8KjefpQ+NFbU/jsdxJioRSU1Uxjmw5XgMZEKZp1x2ECVdZ6EIu5Db5AQE5DuX8SnF"+
                                    "FnPs8tUKDOvLlJbHyVNQapQr5FvPCFZoKsBXa6GO2yreooE9AcppiJREIdfIaUUBx4rk9haF3iWK6xrEIrf3lO8eqj1QDwcHFjrgbkK1b/uQizyV2ngIMzPaC/VezBqx"+
                                    "jRSFRoZtUZiqRBghqpGQ8e1y3c3t3pmVnCB5CiTnYTopZpcMGfEDp51318JjjwYHlbHbPxBK+oDLWOQ4VqKAqLD5JJMJuO/KQmXIN8gRBqqf2HMQNBQCR1tChtAsVutu"+
                                    "WUtUhFWBRSwdxABdZGIJSRGPGyU0kiOGTri1eyjlYCvNl5hXRrC6cnFVNzanfOOma5mEYQjren2zQgdO8W5OQZTctl37hOZzuM1q0l+3YQWuZ77p2qf1IlxfinPZhrOb"+
                                    "rn1ar8L1PDjneweAzEUadkCKWsj7tEW+CCdr1QAjuWSBUe+KmwvVaaNlKTrIBrEdgauY/BLeXoKnXQXW+krAPcfBOupLe3wVfO/+lsjAE9OI9FZzgbhgiwzWU3x4DE2p"+
                                    "6qPHX6tsiQCP9pQ26OEec0iowPuE0ent7Y0a7eevbyMMf/zQelIMbSnVOFUMZWOoc/XZB2MqcaZOkwxbHeJSG0GUiklXERHaLTXFMKlHziKhKTrR/p+mSY+sERNTSWdt"+
                                    "q58hHyduhi9xDeuRqeQLCc50tB3tOkfeDJz+SKLGLF8MtJl1be4/NcNtffHg1MxwWV172nsrug2nm8vv/C8uIuGho5xp8sqfKyNTtZz7n8QFl09bV3nIa9lAX62sDh8X"+
                                    "+sIATn4ifJR/Qfcax+v1G+ECHv//CwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<83&&y<37)?g[y*83+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<83&&y<37)g[y*83+x]=v;}
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0,t1;
        gw(2,3,0);
        gw(1,0,19);
        sa(1);
        sa(-1);
        sa(1);
        sa(-1);
        sa(1);
        sa(-1);
        sa(1);
        sa(-1);
        sa(1);
        sa(-1);
        sa(1);
    _1:
        t0=gr(1,0)-1;
        sa(gr(1,0));

        if(gr(1,0)!=8)goto _115;else goto _2;
    _2:
        gw(35,10,0);
        sp();
        sa(163);
        sa(164);
    _3:
        if(sp()!=0)goto _4;else goto _5;
    _4:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sr()%15)+21);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/15L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _3;
    _5:
        gw(2,0,1);
        sp();
        sa(1);
        sa(1);
    _6:
        gw(3,0,1);
        sa(0);
        sa(0);
        sa(gr(9,0)*gr(3,0));
        gw(3,0,gr(3,0)*gr(2,0));
    _7:
        gw(1,0,sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+gr(1,0));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr()+1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-10L);


        if(sp()!=0)goto _114;else goto _8;
    _8:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+8L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);


        if(sr()!=12)goto _9;else goto _10;
    _9:
        sa(sr());
        sa(sr());
        gw(2,0,sp());
        goto _6;
    _10:
        gw(1,1,1);
        sp();
    _11:
        gw(4,0,1);
    _12:
        sa(0);
        sa(0);
        sa(0);
        sa(1);
        sa(0);
        sa(0);
    _13:
        if(sp()!=0)goto _113;else goto _14;
    _14:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()<gr(1,1))?1:0);

        sa(sp()*sp());

        sa(sp()*(gr(4,0)<=gr(1,1)?1L:0L));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(4,0)-1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);


        if(sr()!=11)goto _112;else goto _15;
    _15:
        gw(35,gr(4,0)-1,gr(gr(4,0)+8,1)*(gr(4,0)<=gr(1,1)?1:0));
        t0=gr(4,0)-11;
        gw(4,0,gr(4,0)+1);
        sp();

        if((t0)!=0)goto _12;else goto _16;
    _16:
        gw(1,2,0);
    _17:
        if((gr(1,1)-1)>gr(1,2))goto _18;else goto _53;
    _18:
        gw(2,2,gr(1,2)+1);
    _19:
        if(gr(1,1)>gr(2,2))goto _20;else goto _52;
    _20:
        gw(3,2,gr(gr(1,2)+21,gr(1,2)));
        gw(4,2,gr(gr(1,2)+21,gr(2,2)));
        gw(35,gr(1,2),gr(35,gr(1,2))*gr(4,2));
        sa(14);
        sa(14);
    _21:
        if(sp()!=0)goto _51;else goto _22;
    _22:
        gw(35,gr(2,2),gr(35,gr(2,2))*gr(3,2));
        sp();
        sa(14);
        sa(14);
    _23:
        if(sp()!=0)goto _50;else goto _24;
    _24:
        gw(35,gr(2,2),gr(35,gr(2,2))-gr(35,gr(1,2)));
        sp();
        sa(14);
        sa(14);
    _25:
        if(sp()!=0)goto _49;else goto _26;
    _26:
        sp();
        sa(gr(35,gr(1,2)));
        sa(gr(gr(1,1)+20,gr(1,2)));
        sa(gr(1,1)-1);
        sa(gr(1,1)-1);
    _27:
        if(sp()!=0)goto _48;else goto _28;
    _28:
        sp();
        sa(gr(1,1));
        gw(2,1,gr(1,1));
    _29:
        if(sp()!=0)goto _30;else goto _33;
    _30:
        sa(sr());

        if(sp()!=0)goto _31;else goto _32;
    _31:
        sa(sr());
        gw(3,3,sp());
        {long v0=sp();sa(tm(sp(),v0));}

        sa(gr(3,3));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _30;
    _32:
        sp();
        sa(gr(2,1)-1);
        gw(2,1,gr(2,1)-1);
        goto _29;
    _33:
        gw(1,0,sp());
        gw(35,gr(1,2),td(gr(35,gr(1,2)),gr(1,0)));
        sa(14);
        sa(14);
    _34:
        if(sp()!=0)goto _47;else goto _35;
    _35:
        sp();
        sa(gr(35,gr(2,2)));
        sa(gr(gr(1,1)+20,gr(2,2)));
        sa(gr(1,1)-1);
        sa(gr(1,1)-1);
    _36:
        if(sp()!=0)goto _46;else goto _37;
    _37:
        sp();
        sa(gr(1,1));
        gw(2,1,gr(1,1));
    _38:
        if(sp()!=0)goto _39;else goto _42;
    _39:
        sa(sr());

        if(sp()!=0)goto _40;else goto _41;
    _40:
        sa(sr());
        gw(3,3,sp());
        {long v0=sp();sa(tm(sp(),v0));}

        sa(gr(3,3));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _39;
    _41:
        sp();
        sa(gr(2,1)-1);
        gw(2,1,gr(2,1)-1);
        goto _38;
    _42:
        gw(1,0,sp());
        gw(35,gr(2,2),td(gr(35,gr(2,2)),gr(1,0)));
        sa(14);
        sa(14);
    _43:
        if(sp()!=0)goto _45;else goto _44;
    _44:
        gw(2,2,gr(2,2)+1);
        sp();
        goto _19;
    _45:
        sa(sp()-1L);

        sa(sr());
        sa(td(gr(sr()+21,gr(2,2)),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(2,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _43;
    _46:
        sa(sp()-1L);

        sa(gr(sr()+21,gr(2,2)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _36;
    _47:
        sa(sp()-1L);

        sa(sr());
        sa(td(gr(sr()+21,gr(1,2)),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _34;
    _48:
        sa(sp()-1L);

        sa(gr(sr()+21,gr(1,2)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _27;
    _49:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        t0=gr(sr()+21,gr(2,2));
        sa(sp()+21L);

        sa(gr(1,2));
        {long v0=sp();t1=gr(sp(),v0);}
        sa(t0-t1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(2,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _25;
    _50:
        sa(sp()-1L);

        sa(sr());
        sa(gr(sr()+21,gr(2,2))*gr(3,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(2,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _23;
    _51:
        sa(sp()-1L);

        sa(sr());
        sa(gr(sr()+21,gr(1,2))*gr(4,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _21;
    _52:
        gw(1,2,gr(1,2)+1);
        goto _17;
    _53:
        gw(1,2,gr(1,1)-2);
        t0=1;
        t1=3;
    _54:
        if(0>gr(1,2))goto _55;else goto _77;
    _55:
        t0=2;
        t1=3;
        sa(gr(1,1)-1);
        sa(gr(gr(1,1)+20,gr(1,1)-1)<0?1:0);
    _56:
        if(sp()!=0)goto _73;else goto _57;
    _57:
        sa(sr());

        if(sp()!=0)goto _72;else goto _58;
    _58:
        gw(19,2,gr(35,10));
        sp();
        sa(10);
        sa(10);
    _59:
        if(sp()!=0)goto _71;else goto _60;
    _60:
        gw(2,0,1);
        gw(3,0,1);
        sp();
        sa(1);
        sa(1);
    _61:
        sa(0);
        sa(0);
        sa(gr(9,2)*gr(3,0));
        gw(3,0,gr(3,0)*gr(2,0));
    _62:
        gw(1,0,sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+gr(1,0));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr()+1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-10L);


        if(sp()!=0)goto _70;else goto _63;
    _63:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+8L);

        sa(3);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);


        if(sr()!=12)goto _64;else goto _65;
    _64:
        sa(sr());
        sa(sr());
        gw(2,0,sp());
        gw(3,0,1);
        goto _61;
    _65:
        gw(3,1,0);
        sp();
    _66:
        if((gr(gr(3,1)+9,1)-gr(gr(3,1)+9,3))!=0)goto _69;else goto _67;
    _67:
        t0=gr(3,1)-10;
        gw(3,1,gr(3,1)+1);

        if((t0)!=0)goto _66;else goto _68;
    _68:
        System.Console.Out.Write(" = ");
        System.Console.Out.Write(gr(2,3)+" ");
        return;
    _69:
        System.Console.Out.Write(gr(gr(3,1)+9,3)+" ");
        System.Console.Out.Write('\n');
        gw(2,3,gr(gr(3,1)+9,3)+gr(2,3));
        gw(1,1,gr(1,1)+1);
        t0=1;
        goto _11;
    _70:
        sa(gr(sr()+9,2)*gr(3,0));
        gw(3,0,gr(3,0)*gr(2,0));
        goto _62;
    _71:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        sa(35);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _59;
    _72:
        sa(sp()-1L);

        sa(sr());
        sa(sr()+21);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()<0)?1:0);
        goto _56;
    _73:
        sa(sr());
        gw(1,2,sp());
        gw(35,gr(1,2),gr(35,gr(1,2))*-1);
        sa(14);
        sa(14);
    _74:
        if(sp()!=0)goto _76;else goto _75;
    _75:
        sp();
        goto _57;
    _76:
        sa(sp()-1L);

        sa(sr());
        sa(gr(sr()+21,gr(1,2))*-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _74;
    _77:
        gw(2,2,gr(1,2)+1);
    _78:
        if(gr(1,1)>gr(2,2))goto _79;else goto _111;
    _79:
        gw(3,2,gr(gr(2,2)+21,gr(1,2)));
        gw(4,2,gr(gr(2,2)+21,gr(2,2)));
        gw(35,gr(1,2),gr(35,gr(1,2))*gr(4,2));
        sa(14);
        sa(14);
    _80:
        if(sp()!=0)goto _110;else goto _81;
    _81:
        gw(35,gr(2,2),gr(35,gr(2,2))*gr(3,2));
        sp();
        sa(14);
        sa(14);
    _82:
        if(sp()!=0)goto _109;else goto _83;
    _83:
        gw(35,gr(1,2),gr(35,gr(1,2))-gr(35,gr(2,2)));
        sp();
        sa(14);
        sa(14);
    _84:
        if(sp()!=0)goto _108;else goto _85;
    _85:
        sp();
        sa(gr(35,gr(1,2)));
        sa(gr(gr(1,1)+20,gr(1,2)));
        sa(gr(1,1)-1);
        sa(gr(1,1)-1);
    _86:
        if(sp()!=0)goto _107;else goto _87;
    _87:
        sp();
        sa(gr(1,1));
        gw(2,1,gr(1,1));
    _88:
        if(sp()!=0)goto _89;else goto _92;
    _89:
        sa(sr());

        if(sp()!=0)goto _90;else goto _91;
    _90:
        sa(sr());
        gw(3,3,sp());
        {long v0=sp();sa(tm(sp(),v0));}

        sa(gr(3,3));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _89;
    _91:
        sp();
        sa(gr(2,1)-1);
        gw(2,1,gr(2,1)-1);
        goto _88;
    _92:
        gw(1,0,sp());
        gw(35,gr(1,2),td(gr(35,gr(1,2)),gr(1,0)));
        sa(14);
        sa(14);
    _93:
        if(sp()!=0)goto _106;else goto _94;
    _94:
        sp();
        sa(gr(35,gr(2,2)));
        sa(gr(gr(1,1)+20,gr(2,2)));
        sa(gr(1,1)-1);
        sa(gr(1,1)-1);
    _95:
        if(sp()!=0)goto _105;else goto _96;
    _96:
        sp();
        sa(gr(1,1));
        gw(2,1,gr(1,1));
    _97:
        if(sp()!=0)goto _98;else goto _101;
    _98:
        sa(sr());

        if(sp()!=0)goto _99;else goto _100;
    _99:
        sa(sr());
        gw(3,3,sp());
        {long v0=sp();sa(tm(sp(),v0));}

        sa(gr(3,3));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _98;
    _100:
        sp();
        sa(gr(2,1)-1);
        gw(2,1,gr(2,1)-1);
        goto _97;
    _101:
        gw(1,0,sp());
        gw(35,gr(2,2),td(gr(35,gr(2,2)),gr(1,0)));
        sa(14);
        sa(14);
    _102:
        if(sp()!=0)goto _104;else goto _103;
    _103:
        gw(2,2,gr(2,2)+1);
        sp();
        goto _78;
    _104:
        sa(sp()-1L);

        sa(sr());
        sa(td(gr(sr()+21,gr(2,2)),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(2,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _102;
    _105:
        sa(sp()-1L);

        sa(gr(sr()+21,gr(2,2)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _95;
    _106:
        sa(sp()-1L);

        sa(sr());
        sa(td(gr(sr()+21,gr(1,2)),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _93;
    _107:
        t0=1;
        sa(sp()-1L);

        sa(gr(sr()+21,gr(1,2)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _86;
    _108:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        t0=gr(sr()+21,gr(1,2));
        sa(sp()+21L);

        sa(gr(2,2));
        {long v0=sp();t1=gr(sp(),v0);}
        sa(t0-t1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _84;
    _109:
        sa(sp()-1L);

        sa(sr());
        sa(gr(sr()+21,gr(2,2))*gr(3,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(2,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _82;
    _110:
        sa(sp()-1L);

        sa(sr());
        sa(gr(sr()+21,gr(1,2))*gr(4,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+21L);

        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _80;
    _111:
        t0=1;
        gw(1,2,gr(1,2)-1);
        goto _54;
    _112:
        sa(sr());
        sa(sr());
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _13;
    _113:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*gr(4,0));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
        goto _13;
    _114:
        sa(gr(sr()+9,0)*gr(3,0));
        gw(3,0,gr(3,0)*gr(2,0));
        goto _7;
    _115:
        gw(1,0,t0);
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
}
}
