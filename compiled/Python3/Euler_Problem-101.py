#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABACtVsuS4yoM/RWl4tlAexpBnHQoiprPuAuKZMeWFSt//EjCSRx3d2burUuVEz9k6ejoSLj9Qyvi2PaPBetzAD7+zTLs0gDg/+fSsksk1//VZRysLait"
  + "rdD6Hccux4bhr11GKO/JnRR5KdXv5kj3vG3WL4YhVjSY40i//Tifob10mQ2WYq1WJ+f9iAFATS5gS8W5H9WFsV3afjzRI18MhmpQ62fEf+QyEzCoNfrdvl28yxj3gzxA"
  + "U03Ni9X3LmNBLO3J5WWgaxPnziuWzP+Hs5r0QUVvkneT+rFNPBaP+mDqNLYifnH0TCbaUpLPjXLPTACzSu6bw2psaL6+MyeJKdomns2hjljMIRxtO030Mpl3OkNDcsbZ"
  + "hUcmhovvKXCaF1HgJ5TXneIaNzWiikNu9H4khGNyOZbYy92XOG7GUBjPuEk9dLqHTyiZQMKoT5DDvCOZuBOIiBZaV+UWVP6sTXGmeGuKAmeqeqafTNKBHjV1mCCO4D3T"
  + "l5EpSj3dVbn5ch71NCWNPmmSESTSEaWFVI1oIr2Oyc+ksQThahSXgRgfCGtns7t8KjefpQ+NFbU/jsdxJioRSU1Uxjmw5XgMZEKZp1x2ECVdZ6EIu5Db5AQE5DuX8SnF"
  + "FnPs8tUKDOvLlJbHyVNQapQr5FvPCFZoKsBXa6GO2yreooE9AcppiJREIdfIaUUBx4rk9haF3iWK6xrEIrf3lO8eqj1QDwcHFjrgbkK1b/uQizyV2ngIMzPaC/VezBqx"
  + "jRSFRoZtUZiqRBghqpGQ8e1y3c3t3pmVnCB5CiTnYTopZpcMGfEDp51318JjjwYHlbHbPxBK+oDLWOQ4VqKAqLD5JJMJuO/KQmXIN8gRBqqf2HMQNBQCR1tChtAsVutu"
  + "WUtUhFWBRSwdxABdZGIJSRGPGyU0kiOGTri1eyjlYCvNl5hXRrC6cnFVNzanfOOma5mEYQjren2zQgdO8W5OQZTctl37hOZzuM1q0l+3YQWuZ77p2qf1IlxfinPZhrOb"
  + "rn1ar8L1PDjneweAzEUadkCKWsj7tEW+CCdr1QAjuWSBUe+KmwvVaaNlKTrIBrEdgauY/BLeXoKnXQXW+krAPcfBOupLe3wVfO/+lsjAE9OI9FZzgbhgiwzWU3x4DE2p"
  + "6qPHX6tsiQCP9pQ26OEec0iowPuE0ent7Y0a7eevbyMMf/zQelIMbSnVOFUMZWOoc/XZB2MqcaZOkwxbHeJSG0GUiklXERHaLTXFMKlHziKhKTrR/p+mSY+sERNTSWdt"
  + "q58hHyduhi9xDeuRqeQLCc50tB3tOkfeDJz+SKLGLF8MtJl1be4/NcNtffHg1MxwWV172nsrug2nm8vv/C8uIuGho5xp8sqfKyNTtZz7n8QFl09bV3nIa9lAX62sDh8X"
  + "+sIATn4ifJR/Qfcax+v1G+ECHv//CwAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<83 and y<37):
        return g[y*83 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<83 and y<37):
        g[y*83 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(2,3,0)
    gw(1,0,19)
    sa(1)
    sa(-1)
    sa(1)
    sa(-1)
    sa(1)
    sa(-1)
    sa(1)
    sa(-1)
    sa(1)
    sa(-1)
    sa(1)
    return 1
def _1():
    global t0
    t0=gr(1,0)-1
    sa(gr(1,0))

    return (115)if(gr(1,0)!=8)else(2)
def _2():
    gw(35,10,0)
    sp();
    sa(163)
    sa(164)
    return 3
def _3():
    return (4)if(sp()!=0)else(5)
def _4():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((sr()%15)+21)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/15);

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 3
def _5():
    gw(2,0,1)
    sp();
    sa(1)
    sa(1)
    return 6
def _6():
    gw(3,0,1)
    sa(0)
    sa(0)
    sa(gr(9,0)*gr(3,0))
    gw(3,0,gr(3,0)*gr(2,0))
    return 7
def _7():
    gw(1,0,sp())
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+gr(1,0))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr()+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-10)


    return (114)if(sp()!=0)else(8)
def _8():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+8)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1)


    return (9)if(sr()!=12)else(10)
def _9():
    sa(sr());
    sa(sr());
    gw(2,0,sp())
    return 6
def _10():
    gw(1,1,1)
    sp();
    return 11
def _11():
    gw(4,0,1)
    return 12
def _12():
    sa(0)
    sa(0)
    sa(0)
    sa(1)
    sa(0)
    sa(0)
    return 13
def _13():
    return (113)if(sp()!=0)else(14)
def _14():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((1)if(sp()<gr(1,1))else(0))

    sa(sp()*sp());

    sa(sp()*((1)if(gr(4,0)<=gr(1,1))else(0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(4,0)-1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1)


    return (112)if(sr()!=11)else(15)
def _15():
    global t0
    gw(35,gr(4,0)-1,gr(gr(4,0)+8,1)*((1)if(gr(4,0)<=gr(1,1))else(0)))
    t0=gr(4,0)-11
    gw(4,0,gr(4,0)+1)
    sp();

    return (12)if((t0)!=0)else(16)
def _16():
    gw(1,2,0)
    return 17
def _17():
    return (18)if((gr(1,1)-1)>gr(1,2))else(53)
def _18():
    gw(2,2,gr(1,2)+1)
    return 19
def _19():
    return (20)if(gr(1,1)>gr(2,2))else(52)
def _20():
    gw(3,2,gr(gr(1,2)+21,gr(1,2)))
    gw(4,2,gr(gr(1,2)+21,gr(2,2)))
    gw(35,gr(1,2),gr(35,gr(1,2))*gr(4,2))
    sa(14)
    sa(14)
    return 21
def _21():
    return (51)if(sp()!=0)else(22)
def _22():
    gw(35,gr(2,2),gr(35,gr(2,2))*gr(3,2))
    sp();
    sa(14)
    sa(14)
    return 23
def _23():
    return (50)if(sp()!=0)else(24)
def _24():
    gw(35,gr(2,2),gr(35,gr(2,2))-gr(35,gr(1,2)))
    sp();
    sa(14)
    sa(14)
    return 25
def _25():
    return (49)if(sp()!=0)else(26)
def _26():
    sp();
    sa(gr(35,gr(1,2)))
    sa(gr(gr(1,1)+20,gr(1,2)))
    sa(gr(1,1)-1)
    sa(gr(1,1)-1)
    return 27
def _27():
    return (48)if(sp()!=0)else(28)
def _28():
    sp();
    sa(gr(1,1))
    gw(2,1,gr(1,1))
    return 29
def _29():
    return (30)if(sp()!=0)else(33)
def _30():
    sa(sr());

    return (31)if(sp()!=0)else(32)
def _31():
    sa(sr());
    gw(3,3,sp())
    v0=sp()
    sa(tm(sp(),v0))

    sa(gr(3,3))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 30
def _32():
    sp();
    sa(gr(2,1)-1)
    gw(2,1,gr(2,1)-1)
    return 29
def _33():
    gw(1,0,sp())
    gw(35,gr(1,2),td(gr(35,gr(1,2)),gr(1,0)))
    sa(14)
    sa(14)
    return 34
def _34():
    return (47)if(sp()!=0)else(35)
def _35():
    sp();
    sa(gr(35,gr(2,2)))
    sa(gr(gr(1,1)+20,gr(2,2)))
    sa(gr(1,1)-1)
    sa(gr(1,1)-1)
    return 36
def _36():
    return (46)if(sp()!=0)else(37)
def _37():
    sp();
    sa(gr(1,1))
    gw(2,1,gr(1,1))
    return 38
def _38():
    return (39)if(sp()!=0)else(42)
def _39():
    sa(sr());

    return (40)if(sp()!=0)else(41)
def _40():
    sa(sr());
    gw(3,3,sp())
    v0=sp()
    sa(tm(sp(),v0))

    sa(gr(3,3))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 39
def _41():
    sp();
    sa(gr(2,1)-1)
    gw(2,1,gr(2,1)-1)
    return 38
def _42():
    gw(1,0,sp())
    gw(35,gr(2,2),td(gr(35,gr(2,2)),gr(1,0)))
    sa(14)
    sa(14)
    return 43
def _43():
    return (45)if(sp()!=0)else(44)
def _44():
    gw(2,2,gr(2,2)+1)
    sp();
    return 19
def _45():
    sa(sp()-1)

    sa(sr());
    sa(td(gr(sr()+21,gr(2,2)),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(2,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 43
def _46():
    sa(sp()-1)

    sa(gr(sr()+21,gr(2,2)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 36
def _47():
    sa(sp()-1)

    sa(sr());
    sa(td(gr(sr()+21,gr(1,2)),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(1,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 34
def _48():
    sa(sp()-1)

    sa(gr(sr()+21,gr(1,2)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 27
def _49():
    global t0
    global t1
    sa(sp()-1)

    sa(sr());
    sa(sr());
    t0=gr(sr()+21,gr(2,2))
    sa(sp()+21)

    sa(gr(1,2))
    v0=sp()
    t1=gr(sp(),v0)
    sa(t0-t1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(2,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 25
def _50():
    sa(sp()-1)

    sa(sr());
    sa(gr(sr()+21,gr(2,2))*gr(3,2))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(2,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 23
def _51():
    sa(sp()-1)

    sa(sr());
    sa(gr(sr()+21,gr(1,2))*gr(4,2))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(1,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 21
def _52():
    gw(1,2,gr(1,2)+1)
    return 17
def _53():
    global t0
    global t1
    gw(1,2,gr(1,1)-2)
    t0=1
    t1=3
    return 54
def _54():
    return (55)if(0>gr(1,2))else(77)
def _55():
    global t0
    global t1
    t0=2
    t1=3
    sa(gr(1,1)-1)
    sa((1)if(gr(gr(1,1)+20,gr(1,1)-1)<0)else(0))
    return 56
def _56():
    return (73)if(sp()!=0)else(57)
def _57():
    sa(sr());

    return (72)if(sp()!=0)else(58)
def _58():
    gw(19,2,gr(35,10))
    sp();
    sa(10)
    sa(10)
    return 59
def _59():
    return (71)if(sp()!=0)else(60)
def _60():
    gw(2,0,1)
    gw(3,0,1)
    sp();
    sa(1)
    sa(1)
    return 61
def _61():
    sa(0)
    sa(0)
    sa(gr(9,2)*gr(3,0))
    gw(3,0,gr(3,0)*gr(2,0))
    return 62
def _62():
    gw(1,0,sp())
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+gr(1,0))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr()+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-10)


    return (70)if(sp()!=0)else(63)
def _63():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+8)

    sa(3)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1)


    return (64)if(sr()!=12)else(65)
def _64():
    sa(sr());
    sa(sr());
    gw(2,0,sp())
    gw(3,0,1)
    return 61
def _65():
    gw(3,1,0)
    sp();
    return 66
def _66():
    return (69)if((gr(gr(3,1)+9,1)-gr(gr(3,1)+9,3))!=0)else(67)
def _67():
    global t0
    t0=gr(3,1)-10
    gw(3,1,gr(3,1)+1)

    return (66)if((t0)!=0)else(68)
def _68():
    print(" = ",end="",flush=True)
    print(gr(2,3),end=" ",flush=True)
    return 116
def _69():
    global t0
    print(gr(gr(3,1)+9,3),end=" ",flush=True)
    print(chr(10),end="",flush=True)
    gw(2,3,gr(gr(3,1)+9,3)+gr(2,3))
    gw(1,1,gr(1,1)+1)
    t0=1
    return 11
def _70():
    sa(gr(sr()+9,2)*gr(3,0))
    gw(3,0,gr(3,0)*gr(2,0))
    return 62
def _71():
    sa(sp()-1)

    sa(sr());
    sa(sr());
    sa(35)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 59
def _72():
    sa(sp()-1)

    sa(sr());
    sa(sr()+21)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((1)if(sp()<0)else(0))
    return 56
def _73():
    sa(sr());
    gw(1,2,sp())
    gw(35,gr(1,2),gr(35,gr(1,2))*-1)
    sa(14)
    sa(14)
    return 74
def _74():
    return (76)if(sp()!=0)else(75)
def _75():
    sp();
    return 57
def _76():
    sa(sp()-1)

    sa(sr());
    sa(gr(sr()+21,gr(1,2))*-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(1,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 74
def _77():
    gw(2,2,gr(1,2)+1)
    return 78
def _78():
    return (79)if(gr(1,1)>gr(2,2))else(111)
def _79():
    gw(3,2,gr(gr(2,2)+21,gr(1,2)))
    gw(4,2,gr(gr(2,2)+21,gr(2,2)))
    gw(35,gr(1,2),gr(35,gr(1,2))*gr(4,2))
    sa(14)
    sa(14)
    return 80
def _80():
    return (110)if(sp()!=0)else(81)
def _81():
    gw(35,gr(2,2),gr(35,gr(2,2))*gr(3,2))
    sp();
    sa(14)
    sa(14)
    return 82
def _82():
    return (109)if(sp()!=0)else(83)
def _83():
    gw(35,gr(1,2),gr(35,gr(1,2))-gr(35,gr(2,2)))
    sp();
    sa(14)
    sa(14)
    return 84
def _84():
    return (108)if(sp()!=0)else(85)
def _85():
    sp();
    sa(gr(35,gr(1,2)))
    sa(gr(gr(1,1)+20,gr(1,2)))
    sa(gr(1,1)-1)
    sa(gr(1,1)-1)
    return 86
def _86():
    return (107)if(sp()!=0)else(87)
def _87():
    sp();
    sa(gr(1,1))
    gw(2,1,gr(1,1))
    return 88
def _88():
    return (89)if(sp()!=0)else(92)
def _89():
    sa(sr());

    return (90)if(sp()!=0)else(91)
def _90():
    sa(sr());
    gw(3,3,sp())
    v0=sp()
    sa(tm(sp(),v0))

    sa(gr(3,3))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 89
def _91():
    sp();
    sa(gr(2,1)-1)
    gw(2,1,gr(2,1)-1)
    return 88
def _92():
    gw(1,0,sp())
    gw(35,gr(1,2),td(gr(35,gr(1,2)),gr(1,0)))
    sa(14)
    sa(14)
    return 93
def _93():
    return (106)if(sp()!=0)else(94)
def _94():
    sp();
    sa(gr(35,gr(2,2)))
    sa(gr(gr(1,1)+20,gr(2,2)))
    sa(gr(1,1)-1)
    sa(gr(1,1)-1)
    return 95
def _95():
    return (105)if(sp()!=0)else(96)
def _96():
    sp();
    sa(gr(1,1))
    gw(2,1,gr(1,1))
    return 97
def _97():
    return (98)if(sp()!=0)else(101)
def _98():
    sa(sr());

    return (99)if(sp()!=0)else(100)
def _99():
    sa(sr());
    gw(3,3,sp())
    v0=sp()
    sa(tm(sp(),v0))

    sa(gr(3,3))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 98
def _100():
    sp();
    sa(gr(2,1)-1)
    gw(2,1,gr(2,1)-1)
    return 97
def _101():
    gw(1,0,sp())
    gw(35,gr(2,2),td(gr(35,gr(2,2)),gr(1,0)))
    sa(14)
    sa(14)
    return 102
def _102():
    return (104)if(sp()!=0)else(103)
def _103():
    gw(2,2,gr(2,2)+1)
    sp();
    return 78
def _104():
    sa(sp()-1)

    sa(sr());
    sa(td(gr(sr()+21,gr(2,2)),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(2,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 102
def _105():
    sa(sp()-1)

    sa(gr(sr()+21,gr(2,2)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 95
def _106():
    sa(sp()-1)

    sa(sr());
    sa(td(gr(sr()+21,gr(1,2)),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(1,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 93
def _107():
    global t0
    t0=1
    sa(sp()-1)

    sa(gr(sr()+21,gr(1,2)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 86
def _108():
    global t0
    global t1
    sa(sp()-1)

    sa(sr());
    sa(sr());
    t0=gr(sr()+21,gr(1,2))
    sa(sp()+21)

    sa(gr(2,2))
    v0=sp()
    t1=gr(sp(),v0)
    sa(t0-t1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(1,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 84
def _109():
    sa(sp()-1)

    sa(sr());
    sa(gr(sr()+21,gr(2,2))*gr(3,2))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(2,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 82
def _110():
    sa(sp()-1)

    sa(sr());
    sa(gr(sr()+21,gr(1,2))*gr(4,2))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+21)

    sa(gr(1,2))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 80
def _111():
    global t0
    t0=1
    gw(1,2,gr(1,2)-1)
    return 54
def _112():
    sa(sr());
    sa(sr());
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 13
def _113():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*gr(4,0))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1)

    sa(sr());
    return 13
def _114():
    sa(gr(sr()+9,0)*gr(3,0))
    gw(3,0,gr(3,0)*gr(2,0))
    return 7
def _115():
    global t0
    gw(1,0,t0)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93,_94,_95,_96,_97,_98,_99,_100,_101,_102,_103,_104,_105,_106,_107,_108,_109,_110,_111,_112,_113,_114,_115]
c=0
while c<116:
    c=m[c]()
