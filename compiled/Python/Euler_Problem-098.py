#!/usr/bin/env python3
# compiled with BefunCompile v1.0.8 (c) 2015
import gzip, base64
_g = ("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")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<258 and y<199):
        return g[y*258 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<258 and y<199):
        g[y*258 + x]=v;
def td(a,b):
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
    gw(1,9,0)
    gw(1,0,0)
    sa(0)
    sa(0)
    sa(0)
    sa(115)
    sa(gr(114,gr(1,0)))
    sa(gr(114,gr(1,0))-32)
    return 1
def _1():
    return (95)if(sp()!=0)else(2)
def _2():
    sp()
    sp()
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 3
def _3():
    return (4)if(sp()!=0)else(87)
def _4():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),100))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),100))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1);
    return (5)if(sr()!=1786)else(6)
def _5():
    sa(sr())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(((tm(sr(),9))*16)+114)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),9))
    gw(1,0,sp())
    sa(sr()+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr()-32)
    return 1
def _6():
    gw(1,1,0)
    gw(2,1,gr(1,1)+1)
    sp()
    return 7
def _7():
    return (8)if(gr((tm(gr(1,1),100))+9,td(gr(1,1),100))!=gr((tm(gr(2,1),100))+9,td(gr(2,1),100)))else(12)
def _8():
    global t0
    t0=gr(2,1)+1
    gw(2,1,gr(2,1)+1)
    t0=(1)if(t0>1786)else(0)
    t0=(0)if(t0!=0)else(1)
    return (7)if((t0)!=0)else(9)
def _9():
    sa(gr(1,1))
    gw((tm(gr(1,1),100))+9,td(gr(1,1),100),35)
    sa(sp()+1);
    sa(sr())
    gw(1,1,sp())
    sa(sp()-1786);
    return (10)if(sp()!=0)else(11)
def _10():
    gw(2,1,gr(1,1)+1)
    return 7
def _11():
    print(gr(1,9),end="",flush=True)
    return 96
def _12():
    sa(((tm(gr(1,1),9))*16)+114)
    gw(1,0,td(gr(1,1),9))
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 13
def _13():
    global t0
    sa(sr()+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32
    return (14)if((t0)!=0)else(15)
def _14():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1);
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 13
def _15():
    sp()
    sa(sr())
    sa(sr())
    gw(3,1,sp())
    sa(sp()-1);
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 16
def _16():
    sa(sr())
    return (86)if(sp()!=0)else(17)
def _17():
    sp()
    return 18
def _18():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (19)if(sp()!=0)else(20)
def _19():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*sp());
    return 18
def _20():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 21
def _21():
    sa(sr())
    return (85)if(sp()!=0)else(22)
def _22():
    sp()
    return 23
def _23():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (24)if(sp()!=0)else(25)
def _24():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*sp());
    return 23
def _25():
    gw(1,0,0)
    sp()
    sa(sp()-1);
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);
    sa(sr())
    gw(2,0,sp())
    return 26
def _26():
    sa(sr())
    gw(3,0,sp())
    sa(sr())
    sa(gr(2,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    sa(sp()+sp());
    sa(td(sp(),2))
    return (83)if(sr()!=gr(3,0))else(27)
def _27():
    gw(1,2,gr(3,0)+1)
    gw(1,0,0)
    sp()
    sa(sr())
    gw(2,0,sp())
    return 28
def _28():
    sa(sr())
    gw(3,0,sp())
    sa(sr())
    sa(gr(2,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    sa(sp()+sp());
    sa(td(sp(),2))
    return (81)if(sr()!=gr(3,0))else(29)
def _29():
    gw(2,2,gr(3,0))
    sp()
    sa(gr(1,2))
    gw(1,3,gr(1,2))
    return 30
def _30():
    sa((1)if(sp()>gr(2,2))else(0))
    sa((0)if(sp()!=0)else(1))
    return (31)if(sp()!=0)else(8)
def _31():
    gw(2,3,gr(1,3)*gr(1,3))
    gw(5,9,124)
    sa(8)
    return 32
def _32():
    sa(sr())
    sa(124)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(5)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 33
def _33():
    return (32)if(sp()!=0)else(34)
def _34():
    gw(110,25,124)
    sp()
    sa(24)
    return 35
def _35():
    sa(sr())
    sa(124)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(110)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 36
def _36():
    return (35)if(sp()!=0)else(37)
def _37():
    gw(1,4,gr(3,1)-1)
    gw(2,4,gr(((tm(gr(1,1),9))*16)+114+gr(1,4),td(gr(1,1),9))-65)
    sp()
    return 38
def _38():
    sa(0)
    sa(gr(3,1)-1-gr(1,4))
    sa(gr(3,1)-1-gr(1,4))
    return 39
def _39():
    return (80)if(sp()!=0)else(40)
def _40():
    sp()
    sa(sr())
    return (41)if(sp()!=0)else(79)
def _41():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (78)if(sp()!=0)else(42)
def _42():
    sp()
    sa(gr(2,3))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    sa(tm(sp(),10))
    gw(3,4,sp())
    sa(gr(110,gr(2,4)))
    return (43)if(gr(110,gr(2,4))!=124)else(77)
def _43():
    sa(sp()-gr(3,4));
    return (51)if(sp()!=0)else(44)
def _44():
    gw(110,gr(2,4),gr(3,4))
    return 45
def _45():
    sa(gr(5,gr(3,4)))
    return (46)if(gr(5,gr(3,4))!=124)else(76)
def _46():
    sa(sp()-gr(2,4));
    return (51)if(sp()!=0)else(47)
def _47():
    gw(5,gr(3,4),gr(2,4)+65)
    return 48
def _48():
    sa(gr(1,4))
    gw(1,4,gr(1,4)-1)
    return (75)if(sp()!=0)else(49)
def _49():
    gw(1,5,0)
    gw(1,4,0)
    return 50
def _50():
    gw(2,4,gr(((tm(gr(2,1),9))*16)+114+gr(1,4),td(gr(2,1),9))-65)
    return (51)if(gr(110,gr(2,4))-124==0)else(52)
def _51():
    sa(gr(1,3)+1)
    gw(1,3,gr(1,3)+1)
    sa(sr())
    gw(1,3,sp())
    return 30
def _52():
    return (51)if(gr(110,gr(2,4))+gr(1,4)==0)else(53)
def _53():
    gw(1,5,(gr(1,5)*10)+gr(110,gr(2,4)))
    sa(gr(1,4)+1)
    gw(1,4,gr(1,4)+1)
    sa(sp()-gr(3,1));
    return (50)if(sp()!=0)else(54)
def _54():
    return (51)if(((1)if(gr(1,5)>gr(2,3))else(0))*((1)if(gr(1,5)>gr(1,9))else(0))==0)else(55)
def _55():
    sa(gr(1,5))
    return (58)if((tm(gr(1,5),64))>57)else(56)
def _56():
    sa(tm(sr(),16))
    return (57)if(sr()>9)else(59)
def _57():
    sp()
    return 58
def _58():
    sp()
    return 51
def _59():
    return (60)if(sr()!=2)else(57)
def _60():
    return (61)if(sr()!=3)else(57)
def _61():
    return (62)if(sr()!=5)else(57)
def _62():
    return (63)if(sr()!=6)else(57)
def _63():
    return (64)if(sr()!=7)else(57)
def _64():
    sa(sp()-8);
    sa((0)if(sp()!=0)else(1))
    return (58)if(sp()!=0)else(65)
def _65():
    sa(tm(sr(),10))
    return (57)if(sr()-7==0)else(66)
def _66():
    return (57)if(sr()-3==0)else(67)
def _67():
    sa(sp()-2);
    sa((0)if(sp()!=0)else(1))
    return (58)if(sp()!=0)else(68)
def _68():
    return (69)if((tm(sr(),3))!=2)else(58)
def _69():
    gw(1,0,0)
    sa(sr())
    gw(2,0,sp())
    return 70
def _70():
    sa(sr())
    gw(3,0,sp())
    sa(sr())
    sa(gr(2,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    sa(sp()+sp());
    sa(td(sp(),2))
    return (73)if(sr()!=gr(3,0))else(71)
def _71():
    sp()
    return (72)if((gr(3,0)*gr(3,0))-gr(2,0)==0)else(51)
def _72():
    gw(1,9,gr(1,5))
    return 51
def _73():
    return (74)if(sr()!=gr(1,0))else(71)
def _74():
    gw(1,0,gr(3,0))
    return 70
def _75():
    gw(2,4,gr(((tm(gr(1,1),9))*16)+114+gr(1,4),td(gr(1,1),9))-65)
    return 38
def _76():
    gw(5,gr(3,4),gr(2,4)+65)
    sp()
    return 48
def _77():
    gw(110,gr(2,4),gr(3,4))
    sp()
    return 45
def _78():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*sp());
    return 41
def _79():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 42
def _80():
    sa(10)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);
    sa(sr())
    return 39
def _81():
    return (82)if(sr()!=gr(1,0))else(29)
def _82():
    gw(1,0,gr(3,0))
    return 28
def _83():
    return (84)if(sr()!=gr(1,0))else(27)
def _84():
    gw(1,0,gr(3,0))
    return 26
def _85():
    sa(10)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);
    return 21
def _86():
    sa(10)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);
    return 16
def _87():
    sa(sp()-65);
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 88
def _88():
    return (94)if(sp()!=0)else(89)
def _89():
    sp()
    sa(sr())
    return (90)if(sp()!=0)else(93)
def _90():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (91)if(sp()!=0)else(92)
def _91():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*sp());
    return 90
def _92():
    sp()
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 3
def _93():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 92
def _94():
    sa(5)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);
    sa(sr())
    return 88
def _95():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr()+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr()-32)
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93,_94,_95]
c=0
while c<96:
    c=m[c]()