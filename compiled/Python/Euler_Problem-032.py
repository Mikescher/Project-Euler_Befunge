# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABADVVsFuwyAM/RUK7ALKhrNGbVBk7UOi9NBVuXLilI8fISRNm5S1nbq074CMjeQn7Ae25CXAeyxNJAoWx9L0Xg3WpKXSxdI0IkBKKBICiW6WpvI77NIEJnClFXR/oL7ELT2jgADvK24NnNQf7XENHm7/GLVlDS4Fgqo1SFAmNdF7wpwe9lTgVhm9VXWWyaH+qN3uTTeooV41CCUY5/jQq4ZgqWNREY36HG0KHDeZY1A7Z5ZlWyFEwqodd1tIoo2IXFedxdlx7eDv+d6olQGueDh6pKv5y+RDxU8TTPiO1hujPEQHMlwpzJNVT+zkMFzIMMGiMi/UuUPk4lOCyNcXH8nn0hDSPV3nAuSnY/40GqLftNePOxdX0BIamqVx9SQUdMDmS4JsWNmkiW7S0Dxu/XTmGtmWY+81We9Jetf3mMDwWRWk0XX6b+PKWIUsNFJXTGLZGbcRKv5ogn4mctL22sKNN9LaqdDZziC9vpBs2vfCK88d0am3VBipwoOAkhWlZsVOvn89mHdg1bcXqpauuaLbkD+gJTv8AFvIfdyeDQAA"
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<166 and y<21):
        return g[y*166 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<166 and y<21):
        g[y*166 + x]=v;
def rd():
    return bool(random.getrandbits(1))
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
    return (121)if(sp()!=0)else(38)
def _1():
    return (120)if(sp()!=0)else(40)
def _2():
    return (42)if(sp()!=0)else(119)
def _3():
    return (43)if(sp()!=0)else(118)
def _4():
    return (44)if(sp()!=0)else(41)
def _5():
    return (46)if(sp()!=0)else(117)
def _6():
    return (47)if(sp()!=0)else(115)
def _7():
    return (48)if(sp()!=0)else(45)
def _8():
    return (50)if(sp()!=0)else(114)
def _9():
    return (51)if(sp()!=0)else(112)
def _10():
    return (52)if(sp()!=0)else(49)
def _11():
    return (111)if(sp()!=0)else(53)
def _12():
    return (54)if(sp()!=0)else(110)
def _13():
    return (56)if(sp()!=0)else(57)
def _14():
    return (58)if(sp()!=0)else(59)
def _15():
    return (60)if(sp()!=0)else(109)
def _16():
    return (108)if(sp()!=0)else(62)
def _17():
    return (64)if(sp()!=0)else(107)
def _18():
    return (65)if(sp()!=0)else(106)
def _19():
    return (66)if(sp()!=0)else(63)
def _20():
    return (68)if(sp()!=0)else(105)
def _21():
    return (69)if(sp()!=0)else(103)
def _22():
    return (70)if(sp()!=0)else(67)
def _23():
    return (72)if(sp()!=0)else(102)
def _24():
    return (73)if(sp()!=0)else(100)
def _25():
    return (74)if(sp()!=0)else(71)
def _26():
    return (99)if(sp()!=0)else(75)
def _27():
    return (76)if(sp()!=0)else(98)
def _28():
    return (78)if(sp()!=0)else(79)
def _29():
    return (97)if(sp()!=0)else(80)
def _30():
    return (96)if(sp()!=0)else(82)
def _31():
    return (85)if(sp()!=0)else(86)
def _32():
    return (87)if(sp()!=0)else(88)
def _33():
    return (93)if(sp()!=0)else(89)
def _34():
    return (95)if(sp()!=0)else(94)
def _35():
    return (91)if(sp()!=0)else(92)
def _36():
    return (84)if(sp()!=0)else(83)
def _37():
    sa(31)
    sa(31)
    return 0
def _38():
    gw(1,0,1)
    gw(8,0,9999)
    sp()
    sa(9)
    sa(9)
    return 39
def _39():
    sa(gr(8,0))
    sa(9)
    sa(9)
    return 1
def _40():
    sp()
    sa(sr())
    return 41
def _41():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 2
def _42():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 3
def _43():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 4
def _44():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 45
def _45():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 5
def _46():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 6
def _47():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 7
def _48():
    sp()
    sa(sp()*sp());
    sa(sr())
    return 49
def _49():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 8
def _50():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 9
def _51():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 10
def _52():
    sp()
    sa(9)
    sa(9)
    return 11
def _53():
    sp()
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(9)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 12
def _54():
    sa(gr(1,0))
    gw(1,0,(gr(1,0))+(1))
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 55
def _55():
    sa((gr(8,0))-(1))
    sa(((gr(8,0))-(1))-(1000))
    return 13
def _56():
    gw(8,0,sp())
    sa(sr())
    return 39
def _57():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return 14
def _58():
    gw(8,0,9999)
    sa(sr())
    return 39
def _59():
    sp()
    sa(1)
    return 15
def _60():
    gw(8,0,999)
    sa(99)
    sa(99)
    return 61
def _61():
    sa(gr(8,0))
    sa(9)
    sa(9)
    return 16
def _62():
    sp()
    sa(sr())
    return 63
def _63():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 17
def _64():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 18
def _65():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 19
def _66():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 67
def _67():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 20
def _68():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 21
def _69():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 22
def _70():
    sp()
    sa(sp()*sp());
    sa(sr())
    return 71
def _71():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 23
def _72():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 24
def _73():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 25
def _74():
    sp()
    sa(9)
    sa(9)
    return 26
def _75():
    sp()
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(9)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 27
def _76():
    sa(gr(1,0))
    gw(1,0,(gr(1,0))+(1))
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 77
def _77():
    sa((gr(8,0))-(1))
    sa(((gr(8,0))-(1))-(100))
    return 28
def _78():
    sa(0)
    return 15
def _79():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(10)
    v0=sp()
    sa(sp()-v0)
    return 29
def _80():
    gw(8,0,32)
    gw(7,0,(gr(8,0))-(1))
    sp()
    return 81
def _81():
    sa(gr(gr(8,0),2))
    sa((0)if((gr(gr(8,0),2))!=0)else(1))
    return 30
def _82():
    sa(gr(gr(7,0),2))
    v0=sp()
    sa(sp()-v0)
    return 36
def _83():
    gw(gr(7,0),2,0)
    return 84
def _84():
    sa(gr(7,0))
    sa((gr(7,0))-(1))
    return 31
def _85():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    gw(7,0,sp())
    return 81
def _86():
    sp()
    sa(gr(8,0))
    sa((gr(8,0))-(2))
    return 32
def _87():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    gw(8,0,sp())
    gw(7,0,(gr(8,0))-(1))
    return 81
def _88():
    sp()
    sa(0)
    sa(31)
    sa(31)
    return 33
def _89():
    sp()
    return 90
def _90():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 35
def _91():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 90
def _92():
    sa(sp()+sp());
    print(sp(),end="",flush=True)
    return 122
def _93():
    sa(sr())
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr())
    return 34
def _94():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 33
def _95():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 33
def _96():
    sp()
    return 84
def _97():
    sa(999)
    return 78
def _98():
    sp()
    return 77
def _99():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 26
def _100():
    sp()
    return 101
def _101():
    sp()
    sp()
    sa(0)
    sa(0)
    return 27
def _102():
    sp()
    return 101
def _103():
    sp()
    return 104
def _104():
    sp()
    return 101
def _105():
    sp()
    return 104
def _106():
    sp()
    return 104
def _107():
    sp()
    return 104
def _108():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 16
def _109():
    gw(8,0,sp())
    sa(sr())
    return 61
def _110():
    sp()
    return 55
def _111():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 11
def _112():
    sp()
    return 113
def _113():
    sp()
    sp()
    sa(0)
    sa(0)
    return 12
def _114():
    sp()
    return 113
def _115():
    sp()
    return 116
def _116():
    sp()
    return 113
def _117():
    sp()
    return 116
def _118():
    sp()
    return 116
def _119():
    sp()
    return 116
def _120():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 1
def _121():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93,_94,_95,_96,_97,_98,_99,_100,_101,_102,_103,_104,_105,_106,_107,_108,_109,_110,_111,_112,_113,_114,_115,_116,_117,_118,_119,_120,_121]
c=37
while c<122:
    c=m[c]()