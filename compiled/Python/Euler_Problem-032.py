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
    return (65)if(sp()!=0)else(10)
def _1():
    return (64)if(sp()!=0)else(12)
def _2():
    return (55)if(sp()!=0)else(16)
def _3():
    return (17)if(sp()!=0)else(54)
def _4():
    return (21)if(sp()!=0)else(53)
def _5():
    return (52)if(sp()!=0)else(23)
def _6():
    return (43)if(sp()!=0)else(27)
def _7():
    return (28)if(sp()!=0)else(42)
def _8():
    return (75)if(sp()!=0)else(35)
def _9():
    sa(31)
    sa(31)
    return 0
def _10():
    gw(1,0,1)
    gw(8,0,9999)
    sp()
    sa(9)
    sa(9)
    return 11
def _11():
    sa(gr(8,0))
    sa(9)
    sa(9)
    return 1
def _12():
    sp()
    sa(sr())
    return 66
def _13():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 88
def _14():
    sp()
    sa(sp()*sp());
    sa(sr())
    return 91
def _15():
    sp()
    sa(9)
    sa(9)
    return 2
def _16():
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
    return 3
def _17():
    sa(gr(1,0))
    gw(1,0,(gr(1,0))+(1))
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 67
def _18():
    gw(8,0,sp())
    sa(sr())
    return 11
def _19():
    gw(8,0,9999)
    sa(sr())
    return 11
def _20():
    sp()
    sa(1)
    return 4
def _21():
    gw(8,0,999)
    sa(99)
    sa(99)
    return 22
def _22():
    sa(gr(8,0))
    sa(9)
    sa(9)
    return 5
def _23():
    sp()
    sa(sr())
    return 69
def _24():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 80
def _25():
    sp()
    sa(sp()*sp());
    sa(sr())
    return 83
def _26():
    sp()
    sa(9)
    sa(9)
    return 6
def _27():
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
    return 7
def _28():
    sa(gr(1,0))
    gw(1,0,(gr(1,0))+(1))
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 70
def _29():
    sa(0)
    return 4
def _30():
    gw(8,0,32)
    gw(7,0,(gr(8,0))-(1))
    sp()
    return 72
def _31():
    gw(gr(7,0),2,0)
    return 73
def _32():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    gw(7,0,sp())
    return 72
def _33():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    gw(8,0,sp())
    gw(7,0,(gr(8,0))-(1))
    return 72
def _34():
    sp()
    sa(0)
    sa(31)
    sa(31)
    return 8
def _35():
    sp()
    return 76
def _36():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 76
def _37():
    sa(sp()+sp());
    print(sp(),end="",flush=True)
    return 94
def _38():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 8
def _39():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 8
def _40():
    sp()
    return 73
def _41():
    sa(999)
    return 29
def _42():
    sp()
    return 70
def _43():
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
    return 6
def _44():
    sp()
    return 45
def _45():
    sp()
    sp()
    sa(0)
    sa(0)
    return 7
def _46():
    sp()
    return 45
def _47():
    sp()
    return 48
def _48():
    sp()
    return 45
def _49():
    sp()
    return 48
def _50():
    sp()
    return 48
def _51():
    sp()
    return 48
def _52():
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
def _53():
    gw(8,0,sp())
    sa(sr())
    return 22
def _54():
    sp()
    return 67
def _55():
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
    return 2
def _56():
    sp()
    return 57
def _57():
    sp()
    sp()
    sa(0)
    sa(0)
    return 3
def _58():
    sp()
    return 57
def _59():
    sp()
    return 60
def _60():
    sp()
    return 57
def _61():
    sp()
    return 60
def _62():
    sp()
    return 60
def _63():
    sp()
    return 60
def _64():
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
def _65():
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
def _66():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (86)if(sp()!=0)else(63)
def _67():
    sa((gr(8,0))-(1))
    sa(((gr(8,0))-(1))-(1000))
    return (18)if(sp()!=0)else(68)
def _68():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return (19)if(sp()!=0)else(20)
def _69():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (78)if(sp()!=0)else(51)
def _70():
    sa((gr(8,0))-(1))
    sa(((gr(8,0))-(1))-(100))
    return (29)if(sp()!=0)else(71)
def _71():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(10)
    v0=sp()
    sa(sp()-v0)
    return (41)if(sp()!=0)else(30)
def _72():
    sa(gr(gr(8,0),2))
    sa((0)if((gr(gr(8,0),2))!=0)else(1))
    return (40)if(sp()!=0)else(77)
def _73():
    sa(gr(7,0))
    sa((gr(7,0))-(1))
    return (32)if(sp()!=0)else(74)
def _74():
    sp()
    sa(gr(8,0))
    sa((gr(8,0))-(2))
    return (33)if(sp()!=0)else(34)
def _75():
    sa(sr())
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr())
    return (39)if(sp()!=0)else(38)
def _76():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (36)if(sp()!=0)else(37)
def _77():
    sa(gr(gr(7,0),2))
    v0=sp()
    sa(sp()-v0)
    return (73)if(sp()!=0)else(31)
def _78():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (79)if(sp()!=0)else(50)
def _79():
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
    return (24)if(sp()!=0)else(69)
def _80():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (81)if(sp()!=0)else(49)
def _81():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (82)if(sp()!=0)else(47)
def _82():
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
    return (25)if(sp()!=0)else(80)
def _83():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (84)if(sp()!=0)else(46)
def _84():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (85)if(sp()!=0)else(44)
def _85():
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
    return (26)if(sp()!=0)else(83)
def _86():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (87)if(sp()!=0)else(62)
def _87():
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
    return (13)if(sp()!=0)else(66)
def _88():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (89)if(sp()!=0)else(61)
def _89():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (90)if(sp()!=0)else(59)
def _90():
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
    return (14)if(sp()!=0)else(88)
def _91():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return (92)if(sp()!=0)else(58)
def _92():
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (93)if(sp()!=0)else(56)
def _93():
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
    return (15)if(sp()!=0)else(91)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93]
c=9
while c<94:
    c=m[c]()