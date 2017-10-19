#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
from random import randint
import gzip, base64
_g = ("AR+LCAAAAAAABACtVMFy4yAM/RXVuLMzMN4FDGnCUKWf0YOH9uarT5zcf18JO8ROsrs9rA5PSAEhPT+SAeD9Hf6XvX7TeG9ejsSCOd4XO3/T6HAsJWKcu+apCeTU6Rg2"
  + "JVE7PTVfX2+NlP4o8+4ejj6ygM5ErmJ0yRmNS4ulTJzj7ZGLPeicK8AcVLTnJKQrrr3uS/sjaLpglR7MtO/rxlIfN25j3TaYw74vRMwLbCgucXXVs9nNjO3tTcYyMQwi"
  + "TdpF5X0btSl0rG7xa73aC6DTY6ApzWjUQG5Ckc79AkrRJ3kO9IU4tuhkceriZwz+ILv5OuMDdtClHAlA1Dkp7lP5bXHV7w+2/pj3xEcefe7kyRUpSbssXsJKagYavsy+"
  + "ZZpNZJBxz2/a7KgbH2jm3gp7Lez4FUvh5bPlOxC3uarUIpI9vxBmlh4BdHX5NwCxFjMcBpt3/KL3KqM/AOHByYzNj4bizK8vw+YtLc2TIPquRHOYrIKIIRhlR9bIAJZW"
  + "BAZGGD7/yFCuuqXO8GDpYWNbUokedIidmewwgvbKQugMTFx3AL4DQqBQe7qAjNLhIwluyp2sVFVsqEl8R0lNzCwVa2H82TM4YHy7a4lLHJ5pkF9WekmMtJR7cetfTqKL"
  + "mQQUMV3IRFHxAtdgnW7VC17mTg8E9A9x3Wcp0/Ir/g3VSFYoBAYAAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
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
    sa(39)
    sa(39)
    return 1
def _1():
    return (98)if(sp()!=0)else(2)
def _2():
    sp();
    return 3
def _3():
    sa(gr(4,0))
    gw(gr(4,0)+2,1,gr(gr(4,0)+2,1)+1)
    return 4
def _4():
    return (((97)if(rd())else(96))if(rd())else((95)if(rd())else(5)))
def _5():
    sa(2)
    return 6
def _6():
    return (((94)if(rd())else(93))if(rd())else((92)if(rd())else(7)))
def _7():
    sa(sp()+3)
    return 8
def _8():
    sa(sp()+sp());

    sa(sp()%40);

    sa(sr());
    gw(4,0,sp())
    return 9
def _9():
    return (((91)if(rd())else(90))if(rd())else((89)if(rd())else(10)))
def _10():
    sa(8)
    return 11
def _11():
    return (((88)if(rd())else(87))if(rd())else((86)if(rd())else(12)))
def _12():
    sa(sp()+2)
    return 13
def _13():
    sa(sp()*4)
    return 14
def _14():
    return (((85)if(rd())else(84))if(rd())else((83)if(rd())else(15)))
def _15():
    sa(sp()+2)
    return 16
def _16():
    return (29)if(sp()!=0)else(17)
def _17():
    gw(4,0,10)
    sp();
    return 18
def _18():
    sa(sp()-1)

    sa(sr());

    return (3)if(sp()!=0)else(19)
def _19():
    gw(41,2,39)
    sp();
    sa(39)
    sa(39)
    return 20
def _20():
    return (28)if(sp()!=0)else(21)
def _21():
    sp();
    sa(0)
    sa(1)
    return 22
def _22():
    return (23)if(sp()!=0)else(27)
def _23():
    sa(sr());

    return (24)if(sp()!=0)else(26)
def _24():
    global t0
    global t1
    global t2
    sa(sr());
    t0=gr(gr(sr()+1,2)+2,1)
    sa(sp()+2)

    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+2)

    sa(1)
    v0=sp()
    t1=gr(sp(),v0)
    t2=(1)if(t0<t1)else(0)

    return (25)if((t2)!=0)else(26)
def _25():
    gw(5,0,gr(sr()+2,2))
    sa(sr());
    sa(gr(sr()+1,2))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+2)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1)

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
    sa(sp()-1)
    return 23
def _26():
    sa(sp()+1)

    sa((1)if(sr()<40)else(0))
    return 22
def _27():
    print(gr(2,2),end=" ",flush=True)
    print(gr(3,2),end=" ",flush=True)
    print(gr(4,2),end=" ",flush=True)
    sp();
    return 99
def _28():
    sa(sp()-1)

    sa(sr());
    sa(sr()+2)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 20
def _29():
    return (30)if(sr()!=30)else(17)
def _30():
    return (45)if(sr()!=2)else(31)
def _31():
    sp();
    return 32
def _32():
    return (((44)if(rd())else(43))if(rd())else((42)if(rd())else(33)))
def _33():
    sa(8)
    return 34
def _34():
    return (((41)if(rd())else(40))if(rd())else((39)if(rd())else(35)))
def _35():
    sa(sp()+2)
    return 36
def _36():
    sa(sr());

    return (37)if(sp()!=0)else(17)
def _37():
    sa(sp()-1)


    return (18)if(sp()!=0)else(38)
def _38():
    gw(4,0,0)
    return 18
def _39():
    sa(sp()+1)
    return 36
def _40():
    sa(sp()+0)
    return 36
def _41():
    sa(sp()+3)
    return 36
def _42():
    sa(4)
    return 34
def _43():
    sa(0)
    return 34
def _44():
    sa(12)
    return 34
def _45():
    return (46)if(sr()!=17)else(31)
def _46():
    return (47)if(sr()!=33)else(31)
def _47():
    return (81)if(sr()!=7)else(48)
def _48():
    sp();
    return 49
def _49():
    return (((80)if(rd())else(79))if(rd())else((78)if(rd())else(50)))
def _50():
    sa(8)
    return 51
def _51():
    return (((77)if(rd())else(76))if(rd())else((75)if(rd())else(52)))
def _52():
    sa(sp()+2)
    return 53
def _53():
    sa(sr());

    return (54)if(sp()!=0)else(74)
def _54():
    sa(sp()-1)

    sa(sr());

    return (55)if(sp()!=0)else(73)
def _55():
    sa(sp()-1)

    sa(sr());

    return (56)if(sp()!=0)else(72)
def _56():
    sa(sp()-1)

    sa(sr());

    return (57)if(sp()!=0)else(71)
def _57():
    sa(sp()-1)

    sa(sr());

    return (58)if(sp()!=0)else(70)
def _58():
    sa(sp()-1)

    sa(sr());

    return (59)if(sp()!=0)else(69)
def _59():
    sa(sp()-1)

    sa(sr());

    return (60)if(sp()!=0)else(68)
def _60():
    sa(sp()-1)

    sa(sr());

    return (61)if(sp()!=0)else(68)
def _61():
    sa(sp()-1)

    sa(sr());

    return (62)if(sp()!=0)else(65)
def _62():
    sa(sp()-1)

    sa(sr());

    return (63)if(sp()!=0)else(64)
def _63():
    sp();
    return 18
def _64():
    gw(4,0,gr(4,0)-3)
    return 63
def _65():
    return (66)if(gr(4,0)!=22)else(67)
def _66():
    gw(4,0,12)
    return 63
def _67():
    gw(4,0,28)
    return 63
def _68():
    gw(4,0,(10*(((gr(4,0)%6)+1)/2))+5)
    return 63
def _69():
    gw(4,0,0)
    return 63
def _70():
    gw(4,0,5)
    return 63
def _71():
    gw(4,0,39)
    return 63
def _72():
    gw(4,0,24)
    return 63
def _73():
    gw(4,0,11)
    return 63
def _74():
    gw(4,0,10)
    return 63
def _75():
    sa(sp()+1)
    return 53
def _76():
    sa(sp()+3)
    return 53
def _77():
    sa(sp()+0)
    return 53
def _78():
    sa(4)
    return 51
def _79():
    sa(12)
    return 51
def _80():
    sa(0)
    return 51
def _81():
    return (82)if(sr()!=22)else(48)
def _82():
    return (63)if(sr()!=36)else(48)
def _83():
    sa(sp()+1)
    return 16
def _84():
    sa(sp()+3)
    return 16
def _85():
    sa(sp()+0)
    return 16
def _86():
    sa(sp()+1)
    return 13
def _87():
    sa(sp()+3)
    return 13
def _88():
    sa(sp()+0)
    return 13
def _89():
    sa(4)
    return 11
def _90():
    sa(12)
    return 11
def _91():
    sa(0)
    return 11
def _92():
    sa(sp()+2)
    return 8
def _93():
    sa(sp()+4)
    return 8
def _94():
    sa(sp()+1)
    return 8
def _95():
    sa(3)
    return 6
def _96():
    sa(4)
    return 6
def _97():
    sa(1)
    return 6
def _98():
    sa(sp()-1)

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
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93,_94,_95,_96,_97,_98]
c=0
while c<99:
    c=m[c]()
