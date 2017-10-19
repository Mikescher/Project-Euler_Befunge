#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("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")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<218 and y<50):
        return g[y*218 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<218 and y<50):
        g[y*218 + x]=v;
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
    sa(0)
    sa(49)
    sa(1)
    return 1
def _1():
    return (3)if(sp()!=0)else(2)
def _2():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+((((gr(9,1)-48)*10)+(gr(10,1)-48))*10)+(gr(11,1)-48))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 3
def _3():
    sa(sr());
    gw(6,0,sp())
    gw(1,3,80)
    gw((gr(1,3)%9)+9,(gr(1,3)/9)+1,gr((gr(1,3)%9)+((gr(6,0)/5)*9)+128,8+((gr(6,0)%5)*9)))
    sa(80)
    sa(80)
    return 4
def _4():
    return (94)if(sp()!=0)else(5)
def _5():
    sp();

    return (7)if(sr()!=-1)else(6)
def _6():
    sp();
    print(sp(),end=" ",flush=True)
    return 95
def _7():
    gw(1,1,22)
    gw(6,1,729)
    gw(17,9,(gr(17,9)%16)+48)
    gw(8+gr(1,1),9,0)
    sa(sp()-1)

    sa(80)
    sa(80)
    return 8
def _8():
    return (93)if(sp()!=0)else(9)
def _9():
    gw(2,0,1)
    sp();
    sa(gr(6,1)-1)
    sa(0)
    sa(((gr(6,1)-1)%27)+72)
    sa(((gr(6,1)-1)/27)+1)
    gw(((gr(6,1)-1)%27)+35,((gr(6,1)-1)/27)+1,0)
    return 10
def _10():
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (92)if(sp()!=0)else(11)
def _11():
    gw(3,0,0)
    gw(3,2,8)
    gw(2,2,8)
    gw(1,2,2)
    gw(5,2,1)
    sp();
    sa(80)
    sa(gr(17,9)-48)
    gw(4,2,gr(17,9)-48)
    return 12
def _12():
    return (28)if(sp()!=0)else(13)
def _13():
    sa(sr());

    return (91)if(sp()!=0)else(14)
def _14():
    gw(1,4,0)
    sp();
    return 15
def _15():
    return (16)if(gr(3,0)!=81)else(90)
def _16():
    gw(2,4,8)
    gw(3,4,8)
    sa(80)
    return 17
def _17():
    return (18)if(gr(9+gr(2,4),1+gr(3,4))!=48)else(80)
def _18():
    sa(sr());

    return (79)if(sp()!=0)else(19)
def _19():
    sp();

    return (20)if((gr(1,4))!=0)else(21)
def _20():
    gw(1,4,0)
    return 15
def _21():
    gw(1,5,0)
    return 22
def _22():
    gw(2,5,0)
    gw(3,5,0)
    gw(4,5,0)
    gw(5,5,6561)
    gw(1,6,8)
    gw(2,6,8)
    sa(80)
    return 23
def _23():
    sa(gr(9+gr(1,6),1+gr(2,6))-48)
    return 24
def _24():
    return (25)if(sp()!=0)else(70)
def _25():
    sa(sr());

    return (69)if(sp()!=0)else(26)
def _26():
    sp();

    return (27)if((gr(4,5))!=0)else(55)
def _27():
    global t0
    t0=gr(2,0)+1
    gw(2,0,gr(2,0)+1)
    gw(gr(1,1)+gr(2,5),1+gr(3,5),t0)
    gw(1,2,0)
    gw(2,2,gr(2,5))
    gw(3,2,gr(3,5))
    gw(4,2,gr(4,5))
    gw(5,2,gr(2,0))
    return 28
def _28():
    gw(gr(2,2)+9,gr(3,2)+1,gr(4,2)+48)
    gw(3,0,gr(3,0)+1)
    gw(1,3,8)
    sa(8)
    return 29
def _29():
    gw(35+(gr(2,2)*3)+(gr(1,3)%3),1+(gr(3,2)*3)+(gr(1,3)/3),88)

    return (30)if((gr(72+(gr(2,2)*3)+(gr(1,3)%3),1+(gr(3,2)*3)+(gr(1,3)/3)))!=0)else(54)
def _30():
    sa(sr());
    return 31
def _31():
    return (32)if(sp()!=0)else(33)
def _32():
    sa(sp()-1)

    sa(sr());
    gw(1,3,sp())
    return 29
def _33():
    gw(2,3,8)
    sp();
    sa(8)
    return 34
def _34():
    gw(35+(gr(2,3)*3)+((gr(4,2)-1)%3),1+(gr(3,2)*3)+((gr(4,2)-1)/3),88)

    return (35)if((gr(72+(gr(2,3)*3)+((gr(4,2)-1)%3),1+(gr(3,2)*3)+((gr(4,2)-1)/3)))!=0)else(53)
def _35():
    sa(sr());
    return 36
def _36():
    return (37)if(sp()!=0)else(38)
def _37():
    sa(sp()-1)

    sa(sr());
    gw(2,3,sp())
    return 34
def _38():
    gw(3,3,8)
    sp();
    sa(8)
    return 39
def _39():
    gw(35+(gr(2,2)*3)+((gr(4,2)-1)%3),1+(gr(3,3)*3)+((gr(4,2)-1)/3),88)

    return (40)if((gr(72+(gr(2,2)*3)+((gr(4,2)-1)%3),1+(gr(3,3)*3)+((gr(4,2)-1)/3)))!=0)else(52)
def _40():
    sa(sr());

    return (51)if(sp()!=0)else(41)
def _41():
    gw(2,3,2)
    gw(3,3,2)
    sp();
    sa(8)
    return 42
def _42():
    gw(35+((((gr(2,2)/3)*3)+gr(2,3))*3)+((gr(4,2)-1)%3),1+((((gr(3,2)/3)*3)+gr(3,3))*3)+((gr(4,2)-1)/3),88)

    return (43)if((gr(72+((((gr(2,2)/3)*3)+gr(2,3))*3)+((gr(4,2)-1)%3),1+((((gr(3,2)/3)*3)+gr(3,3))*3)+((gr(4,2)-1)/3)))!=0)else(50)
def _43():
    sa(sr());
    return 44
def _44():
    return (49)if(sp()!=0)else(45)
def _45():
    sp();
    sa(gr(1,2))

    return (46)if((gr(1,2))!=0)else(14)
def _46():
    sa(sp()-1)

    sa(sr());

    return (47)if(sp()!=0)else(48)
def _47():
    sp();
    return 13
def _48():
    sp();
    return 18
def _49():
    sa(sp()-1)

    sa(sr());
    gw(2,3,sr()%3)
    sa(sp()/3);

    gw(3,3,sp())
    return 42
def _50():
    gw(72+((((gr(2,2)/3)*3)+gr(2,3))*3)+((gr(4,2)-1)%3),1+((((gr(3,2)/3)*3)+gr(3,3))*3)+((gr(4,2)-1)/3),gr(5,2))
    sa(sr());
    return 44
def _51():
    sa(sp()-1)

    sa(sr());
    gw(3,3,sp())
    return 39
def _52():
    gw(72+(gr(2,2)*3)+((gr(4,2)-1)%3),1+(gr(3,3)*3)+((gr(4,2)-1)/3),gr(5,2))
    return 40
def _53():
    gw(72+(gr(2,3)*3)+((gr(4,2)-1)%3),1+(gr(3,2)*3)+((gr(4,2)-1)/3),gr(5,2))
    sa(sr());
    return 36
def _54():
    gw(72+(gr(2,2)*3)+(gr(1,3)%3),1+(gr(3,2)*3)+(gr(1,3)/3),gr(5,2))
    sa(sr());
    return 31
def _55():
    gw(1,7,-1)
    gw(2,7,-1)
    gw(3,7,-1)
    gw(5,7,8)
    gw(6,7,8)
    sa(80)
    return 56
def _56():
    return (57)if((gr(22+gr(5,7),1+gr(6,7))-gr(2,0))!=0)else(68)
def _57():
    sa(sr());

    return (67)if(sp()!=0)else(58)
def _58():
    gw(5,7,26)
    gw(6,7,26)
    sp();
    sa(728)
    return 59
def _59():
    return (66)if((gr(72+gr(5,7),1+gr(6,7))-gr(2,0))!=0)else(60)
def _60():
    gw(72+gr(5,7),1+gr(6,7),0)
    gw(35+gr(5,7),1+gr(6,7),0)

    return (65)if(gr(9+(gr(5,7)/3),1+(gr(6,7)/3))!=48)else(61)
def _61():
    sa(sr());
    return 62
def _62():
    return (64)if(sp()!=0)else(63)
def _63():
    gw(2,0,gr(2,0)-1)
    gw(22+gr(2,7),1+gr(3,7),0)
    gw(1,5,gr(1,7))
    sp();
    return 22
def _64():
    sa(sp()-1)

    gw(5,7,sr()%27)
    gw(6,7,sr()/27)
    return 59
def _65():
    gw(9+(gr(5,7)/3),1+(gr(6,7)/3),48)
    gw(3,0,gr(3,0)-1)
    sa(sr());
    return 62
def _66():
    sa(sr());
    return 62
def _67():
    sa(sp()-1)

    gw(5,7,sr()%9)
    gw(6,7,sr()/9)
    return 56
def _68():
    gw(1,7,gr(9+gr(5,7),1+gr(6,7))-48)
    gw(2,7,gr(5,7))
    gw(3,7,gr(6,7))
    return 57
def _69():
    sa(sp()-1)

    gw(1,6,sr()%9)
    gw(2,6,sr()/9)
    return 23
def _70():
    gw(4,6,0)
    gw(5,6,0)
    gw(6,6,1)
    sa(1)
    return 71
def _71():
    return (74)if((gr(35+(gr(1,6)*3)+((gr(6,6)-1)%3),1+(gr(2,6)*3)+((gr(6,6)-1)/3)))!=0)else(72)
def _72():
    gw(5,6,gr(5,6)+1)

    return (74)if((((1)if((gr(4,6))!=0)else(0))+((1)if(gr(6,6)<=gr(1,5))else(0)))!=0)else(73)
def _73():
    gw(4,6,gr(6,6))
    return 74
def _74():
    return (78)if(sr()!=9)else(75)
def _75():
    sp();

    return (76)if((((0)if((gr(5,6))!=0)else(1))+((1)if(gr(5,5)<=gr(5,6))else(0)))!=0)else(77)
def _76():
    sa(1)
    return 24
def _77():
    gw(2,5,gr(1,6))
    gw(3,5,gr(2,6))
    gw(4,5,gr(4,6))
    gw(5,5,gr(5,6))
    return 76
def _78():
    sa(sp()+1)

    sa(sr());
    gw(6,6,sp())
    return 71
def _79():
    sa(sp()-1)

    gw(2,4,sr()%9)
    gw(3,4,sr()/9)
    return 17
def _80():
    gw(5,4,0)
    gw(6,4,0)
    gw(4,4,8)
    sa(8)
    return 81
def _81():
    return (82)if((gr(35+(gr(2,4)*3)+(gr(4,4)%3),1+(gr(3,4)*3)+(gr(4,4)/3)))!=0)else(89)
def _82():
    sa(sr());
    return 83
def _83():
    return (88)if(sp()!=0)else(84)
def _84():
    global t0
    t0=gr(6,4)
    sp();

    return (85)if((gr(6,4))!=0)else(87)
def _85():
    global t0
    t0=t0-1

    return (18)if((t0)!=0)else(86)
def _86():
    gw(1,4,gr(1,4)+1)
    gw(1,2,1)
    gw(2,2,gr(2,4))
    gw(3,2,gr(3,4))
    gw(4,2,gr(5,4))
    gw(5,2,gr(2,0))
    return 28
def _87():
    sp();
    return 55
def _88():
    sa(sp()-1)

    sa(sr());
    gw(4,4,sp())
    return 81
def _89():
    gw(6,4,gr(6,4)+1)
    gw(5,4,gr(4,4)+1)
    sa(sr());
    return 83
def _90():
    sa((0)if(sr()-49!=0)else(1))
    return 1
def _91():
    sa(sp()-1)

    gw(3,2,sr()/9)
    gw(2,2,sr()%9)
    gw(1,2,2)
    gw(5,2,1)
    sa(sr());
    sa((sr()%9)+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/9);

    sa(sp()+1)

    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48)

    sa(sr());
    gw(4,2,sp())
    return 12
def _92():
    sa(sp()-1)

    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((sr()%27)+35)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/27);

    sa(sp()+1)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((sr()%27)+72)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/27);

    sa(sp()+1)
    return 10
def _93():
    sa(sp()-1)

    sa(sr());
    sa(sr());
    sa((sr()%9)+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/9);

    sa(sp()+1)

    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()%16);

    sa(sp()+48)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((sr()%9)+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/9);

    sa(sp()+1)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((sr()%9)+gr(1,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/9);

    sa(sp()+1)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 8
def _94():
    global t0
    sa(sp()-1)

    sa(sr());
    sa(sr());
    gw(1,3,sp())
    sa(sp()/9);

    sa(sp()+((gr(6,0)%5)*9))

    sa((gr(1,3)%9)+((gr(6,0)/5)*9)+128)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    t0=gr(sp(),v0)
    gw((gr(1,3)%9)+9,(gr(1,3)/9)+1,t0)
    sa(sr());
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93,_94]
c=0
while c<95:
    c=m[c]()
