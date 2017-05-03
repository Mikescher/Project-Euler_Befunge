#!/usr/bin/env python2

# transpiled with BefunCompile v1.1.0 (c) 2015
from random import randint
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABACtVMFy4yAM/RXVuLMzMN4FDGnCUKWf0YOH9uarT5zcf18JO8ROsrs9rA5PSAEhPT+SAeD9Hf6XvX7TeG9ejsSCOd4XO3/T6HAsJWKcu+apCeTU6Rg2"
  + "JVE7PTVfX2+NlP4o8+4ejj6ygM5ErmJ0yRmNS4ulTJzj7ZGLPeicK8AcVLTnJKQrrr3uS/sjaLpglR7MtO/rxlIfN25j3TaYw74vRMwLbCgucXXVs9nNjO3tTcYyMQwi"
  + "TdpF5X0btSl0rG7xa73aC6DTY6ApzWjUQG5Ckc79AkrRJ3kO9IU4tuhkceriZwz+ILv5OuMDdtClHAlA1Dkp7lP5bXHV7w+2/pj3xEcefe7kyRUpSbssXsJKagYavsy+"
  + "ZZpNZJBxz2/a7KgbH2jm3gp7Lez4FUvh5bPlOxC3uarUIpI9vxBmlh4BdHX5NwCxFjMcBpt3/KL3KqM/AOHByYzNj4bizK8vw+YtLc2TIPquRHOYrIKIIRhlR9bIAJZW"
  + "BAZGGD7/yFCuuqXO8GDpYWNbUokedIidmewwgvbKQugMTFx3AL4DQqBQe7qAjNLhIwluyp2sVFVsqEl8R0lNzCwVa2H82TM4YHy7a4lLHJ5pkF9WekmMtJR7cetfTqKL"
  + "mQQUMV3IRFHxAtdgnW7VC17mTg8E9A9x3Wcp0/Ir/g3VSFYoBAYAAA==")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<77 and y<20):
        return g[y*77 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<77 and y<20):
        g[y*77 + x]=v;
def rd():
    return bool(random.getrandbits(1))
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
    gw(4,0,0)
    gw(41,1,0)
    sa(1000000)
    sa(38)
    return 1
def _1():
    sa(sr()+2)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (97)if(sp()!=0)else(2)
def _2():
    sp();
    return 3
def _3():
    sa(gr(4,0))
    gw(gr(4,0)+2,1,gr(gr(4,0)+2,1)+1)
    return 4
def _4():
    return (((96)if(rd())else(95))if(rd())else((94)if(rd())else(5)))
def _5():
    sa(2)
    return 6
def _6():
    return (((93)if(rd())else(92))if(rd())else((91)if(rd())else(7)))
def _7():
    sa(sp()+3);
    return 8
def _8():
    sa(sp()+sp());

    sa(tm(sp(),40))

    sa(sr());
    gw(4,0,sp())
    return 9
def _9():
    return (((90)if(rd())else(89))if(rd())else((88)if(rd())else(10)))
def _10():
    sa(8)
    return 11
def _11():
    return (((87)if(rd())else(86))if(rd())else((85)if(rd())else(12)))
def _12():
    sa(sp()+2);
    return 13
def _13():
    sa(sp()*4);
    return 14
def _14():
    return (((84)if(rd())else(83))if(rd())else((82)if(rd())else(15)))
def _15():
    sa(sp()+2);
    return 16
def _16():
    return (28)if(sp()!=0)else(17)
def _17():
    gw(4,0,10)
    sp();
    return 18
def _18():
    sa(sp()-1);

    sa(sr());

    return (3)if(sp()!=0)else(19)
def _19():
    gw(41,2,39)
    sp();
    sa(38)
    return 20
def _20():
    sa(sr());
    sa(sr()+2)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (27)if(sp()!=0)else(21)
def _21():
    sp();
    sa(0)
    return 22
def _22():
    sa(sr());

    return (25)if(sp()!=0)else(23)
def _23():
    sa(sp()+1);


    return (22)if(sr()<40)else(24)
def _24():
    sys.stdout.write(str(gr(2,2)))
    sys.stdout.flush()

    sys.stdout.write(str(gr(3,2)))
    sys.stdout.flush()

    sys.stdout.write(str(gr(4,2)))
    sys.stdout.flush()

    sp();
    return 98
def _25():
    global t0
    global t1
    global t2
    sa(sr());
    sa(sr()+1)
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+2);

    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    sa(sp()+2);

    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+2);

    sa(1)
    v0=sp()
    t1=gr(sp(),v0)
    t2=(1)if(t0<t1)else(0)

    return (26)if((t2)!=0)else(23)
def _26():
    global t0
    sa(sr()+2)
    sa(2)
    v0=sp()
    t0=gr(sp(),v0)
    gw(5,0,t0)
    sa(sr());
    sa(sr()+1)
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+2);

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);

    sa(sr()+2)
    sa(gr(5,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);
    return 22
def _27():
    sa(sp()-1);
    return 20
def _28():
    return (29)if(sr()!=30)else(17)
def _29():
    return (44)if(sr()!=2)else(30)
def _30():
    sp();
    return 31
def _31():
    return (((43)if(rd())else(42))if(rd())else((41)if(rd())else(32)))
def _32():
    sa(8)
    return 33
def _33():
    return (((40)if(rd())else(39))if(rd())else((38)if(rd())else(34)))
def _34():
    sa(sp()+2);
    return 35
def _35():
    sa(sr());

    return (36)if(sp()!=0)else(17)
def _36():
    sa(sp()-1);


    return (18)if(sp()!=0)else(37)
def _37():
    gw(4,0,0)
    return 18
def _38():
    sa(sp()+1);
    return 35
def _39():
    sa(sp()+0);
    return 35
def _40():
    sa(sp()+3);
    return 35
def _41():
    sa(4)
    return 33
def _42():
    sa(0)
    return 33
def _43():
    sa(12)
    return 33
def _44():
    return (45)if(sr()!=17)else(30)
def _45():
    return (46)if(sr()!=33)else(30)
def _46():
    return (80)if(sr()!=7)else(47)
def _47():
    sp();
    return 48
def _48():
    return (((79)if(rd())else(78))if(rd())else((77)if(rd())else(49)))
def _49():
    sa(8)
    return 50
def _50():
    return (((76)if(rd())else(75))if(rd())else((74)if(rd())else(51)))
def _51():
    sa(sp()+2);
    return 52
def _52():
    sa(sr());

    return (53)if(sp()!=0)else(73)
def _53():
    sa(sp()-1);

    sa(sr());

    return (54)if(sp()!=0)else(72)
def _54():
    sa(sp()-1);

    sa(sr());

    return (55)if(sp()!=0)else(71)
def _55():
    sa(sp()-1);

    sa(sr());

    return (56)if(sp()!=0)else(70)
def _56():
    sa(sp()-1);

    sa(sr());

    return (57)if(sp()!=0)else(69)
def _57():
    sa(sp()-1);

    sa(sr());

    return (58)if(sp()!=0)else(68)
def _58():
    sa(sp()-1);

    sa(sr());

    return (59)if(sp()!=0)else(67)
def _59():
    sa(sp()-1);

    sa(sr());

    return (60)if(sp()!=0)else(67)
def _60():
    sa(sp()-1);

    sa(sr());

    return (61)if(sp()!=0)else(64)
def _61():
    sa(sp()-1);

    sa(sr());

    return (62)if(sp()!=0)else(63)
def _62():
    sp();
    return 18
def _63():
    gw(4,0,gr(4,0)-3)
    return 62
def _64():
    return (65)if(gr(4,0)!=22)else(66)
def _65():
    gw(4,0,12)
    return 62
def _66():
    gw(4,0,28)
    return 62
def _67():
    gw(4,0,(10*(td((tm(gr(4,0),6))+1,2)))+5)
    return 62
def _68():
    gw(4,0,0)
    return 62
def _69():
    gw(4,0,5)
    return 62
def _70():
    gw(4,0,39)
    return 62
def _71():
    gw(4,0,24)
    return 62
def _72():
    gw(4,0,11)
    return 62
def _73():
    gw(4,0,10)
    return 62
def _74():
    sa(sp()+1);
    return 52
def _75():
    sa(sp()+3);
    return 52
def _76():
    sa(sp()+0);
    return 52
def _77():
    sa(4)
    return 50
def _78():
    sa(12)
    return 50
def _79():
    sa(0)
    return 50
def _80():
    return (81)if(sr()!=22)else(47)
def _81():
    return (62)if(sr()!=36)else(47)
def _82():
    sa(sp()+1);
    return 16
def _83():
    sa(sp()+3);
    return 16
def _84():
    sa(sp()+0);
    return 16
def _85():
    sa(sp()+1);
    return 13
def _86():
    sa(sp()+3);
    return 13
def _87():
    sa(sp()+0);
    return 13
def _88():
    sa(4)
    return 11
def _89():
    sa(12)
    return 11
def _90():
    sa(0)
    return 11
def _91():
    sa(sp()+2);
    return 8
def _92():
    sa(sp()+1);
    return 8
def _93():
    sa(sp()+4);
    return 8
def _94():
    sa(1)
    return 6
def _95():
    sa(4)
    return 6
def _96():
    sa(3)
    return 6
def _97():
    sa(sp()-1);
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93,_94,_95,_96,_97]
c=0
while c<98:
    c=m[c]()
