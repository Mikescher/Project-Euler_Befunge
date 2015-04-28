# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("AR+LCAAAAAAABADVVsFuwyAM/RUK7ALKhrNGbVBk7UOi9NBVuXLilI8fISRNm5S1nbq074CMjeQn7Ae25CXAeyxNJAoWx9L0Xg3WpKXSxdI0IkBKKBICiW6WpvI77NIE"
  + "JnClFXR/oL7ELT2jgADvK24NnNQf7XENHm7/GLVlDS4Fgqo1SFAmNdF7wpwe9lTgVhm9VXWWyaH+qN3uTTeooV41CCUY5/jQq4ZgqWNREY36HG0KHDeZY1A7Z5ZlWyFE"
  + "wqodd1tIoo2IXFedxdlx7eDv+d6olQGueDh6pKv5y+RDxU8TTPiO1hujPEQHMlwpzJNVT+zkMFzIMMGiMi/UuUPk4lOCyNcXH8nn0hDSPV3nAuSnY/40GqLftNePOxdX"
  + "0BIamqVx9SQUdMDmS4JsWNmkiW7S0Dxu/XTmGtmWY+81We9Jetf3mMDwWRWk0XX6b+PKWIUsNFJXTGLZGbcRKv5ogn4mctL22sKNN9LaqdDZziC9vpBs2vfCK88d0am3"
  + "VBipwoOAkhWlZsVOvn89mHdg1bcXqpauuaLbkD+gJTv8AFvIfdyeDQAA")
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
    sa(31)
    sa(31)
    return 1
def _1():
    return (2)if(sp()!=0)else(3)
def _2():
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
    return 1
def _3():
    gw(1,0,1)
    gw(8,0,9999)
    sp()
    sa(9)
    sa(9)
    return 4
def _4():
    sa(gr(8,0))
    sa(9)
    sa(9)
    return 5
def _5():
    return (6)if(sp()!=0)else(7)
def _6():
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
    return 5
def _7():
    sp()
    sa(sr())
    return 8
def _8():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (9)if(sp()!=0)else(93)
def _9():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (10)if(sp()!=0)else(92)
def _10():
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
    return (11)if(sp()!=0)else(8)
def _11():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 12
def _12():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (13)if(sp()!=0)else(91)
def _13():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (14)if(sp()!=0)else(89)
def _14():
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
    return (15)if(sp()!=0)else(12)
def _15():
    sp()
    sa(sp()*sp());
    sa(sr())
    return 16
def _16():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (17)if(sp()!=0)else(88)
def _17():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (18)if(sp()!=0)else(86)
def _18():
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
    return (19)if(sp()!=0)else(16)
def _19():
    sp()
    sa(9)
    sa(9)
    return 20
def _20():
    return (21)if(sp()!=0)else(22)
def _21():
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
    return 20
def _22():
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
    return 23
def _23():
    return (85)if(sp()!=0)else(24)
def _24():
    sp()
    return 25
def _25():
    sa((gr(8,0))-(1))
    sa(((gr(8,0))-(1))-(1000))
    return (84)if(sp()!=0)else(26)
def _26():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return (83)if(sp()!=0)else(27)
def _27():
    sp()
    sa(1)
    return 28
def _28():
    return (82)if(sp()!=0)else(29)
def _29():
    gw(8,0,sp())
    sa(sr())
    return 30
def _30():
    sa(gr(8,0))
    sa(9)
    sa(9)
    return 31
def _31():
    return (32)if(sp()!=0)else(33)
def _32():
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
    return 31
def _33():
    sp()
    sa(sr())
    return 34
def _34():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (35)if(sp()!=0)else(81)
def _35():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (36)if(sp()!=0)else(80)
def _36():
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
    return (37)if(sp()!=0)else(34)
def _37():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 38
def _38():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (39)if(sp()!=0)else(79)
def _39():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (40)if(sp()!=0)else(77)
def _40():
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
    return (41)if(sp()!=0)else(38)
def _41():
    sp()
    sa(sp()*sp());
    sa(sr())
    return 42
def _42():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (43)if(sp()!=0)else(76)
def _43():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (44)if(sp()!=0)else(74)
def _44():
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
    return (45)if(sp()!=0)else(42)
def _45():
    sp()
    sa(9)
    sa(9)
    return 46
def _46():
    return (47)if(sp()!=0)else(48)
def _47():
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
    return 46
def _48():
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
    return 49
def _49():
    return (73)if(sp()!=0)else(50)
def _50():
    sp()
    return 51
def _51():
    sa((gr(8,0))-(1))
    sa(((gr(8,0))-(1))-(100))
    return (54)if(sp()!=0)else(52)
def _52():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(10)
    v0=sp()
    sa(sp()-v0)
    return (53)if(sp()!=0)else(55)
def _53():
    sa(999)
    return 54
def _54():
    sa(0)
    return 28
def _55():
    gw(8,0,32)
    gw(7,0,(gr(8,0))-(1))
    sp()
    return 56
def _56():
    sa(gr(gr(8,0),2))
    sa((0)if((gr(gr(8,0),2))!=0)else(1))
    return (72)if(sp()!=0)else(57)
def _57():
    sa(gr(gr(7,0),2))
    v0=sp()
    sa(sp()-v0)
    return (58)if(sp()!=0)else(71)
def _58():
    sa(gr(7,0))
    sa((gr(7,0))-(1))
    return (70)if(sp()!=0)else(59)
def _59():
    sp()
    sa(gr(8,0))
    sa((gr(8,0))-(2))
    return (69)if(sp()!=0)else(60)
def _60():
    sp()
    sa(0)
    sa(31)
    sa(31)
    return 61
def _61():
    return (62)if(sp()!=0)else(65)
def _62():
    sa(sr())
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr())
    return (63)if(sp()!=0)else(64)
def _63():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 61
def _64():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 61
def _65():
    sp()
    return 66
def _66():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (68)if(sp()!=0)else(67)
def _67():
    sa(sp()+sp());
    print(sp(),end="",flush=True)
    return 94
def _68():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 66
def _69():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    gw(8,0,sp())
    gw(7,0,(gr(8,0))-(1))
    return 56
def _70():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    gw(7,0,sp())
    return 56
def _71():
    gw(gr(7,0),2,0)
    return 58
def _72():
    sp()
    return 58
def _73():
    sa(gr(1,0))
    gw(1,0,(gr(1,0))+(1))
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 51
def _74():
    sp()
    return 75
def _75():
    sp()
    sp()
    sa(0)
    sa(0)
    return 49
def _76():
    sp()
    return 75
def _77():
    sp()
    return 78
def _78():
    sp()
    return 75
def _79():
    sp()
    return 78
def _80():
    sp()
    return 78
def _81():
    sp()
    return 78
def _82():
    gw(8,0,999)
    sa(99)
    sa(99)
    return 30
def _83():
    gw(8,0,9999)
    sa(sr())
    return 4
def _84():
    gw(8,0,sp())
    sa(sr())
    return 4
def _85():
    sa(gr(1,0))
    gw(1,0,(gr(1,0))+(1))
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 25
def _86():
    sp()
    return 87
def _87():
    sp()
    sp()
    sa(0)
    sa(0)
    return 23
def _88():
    sp()
    return 87
def _89():
    sp()
    return 90
def _90():
    sp()
    return 87
def _91():
    sp()
    return 90
def _92():
    sp()
    return 90
def _93():
    sp()
    return 90
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93]
c=0
while c<94:
    c=m[c]()