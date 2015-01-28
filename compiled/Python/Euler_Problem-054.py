# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="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"
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<118 and y<1009):
        return g[y*118 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<118 and y<1009):
        g[y*118 + x]=v;
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
    return (42)if(sp()!=0)else(28)
def _1():
    return (32)if(sp()!=0)else(44)
def _2():
    return (34)if(sp()!=0)else(35)
def _3():
    return (38)if(sp()!=0)else(36)
def _4():
    return (40)if(sp()!=0)else(39)
def _5():
    return (41)if(sp()!=0)else(43)
def _6():
    return (42)if(sp()!=0)else(28)
def _7():
    return (37)if(sp()!=0)else(38)
def _8():
    return (20)if(sp()!=0)else(46)
def _9():
    return (47)if(sp()!=0)else(48)
def _10():
    return (49)if(sp()!=0)else(50)
def _11():
    return (51)if(sp()!=0)else(52)
def _12():
    return (53)if(sp()!=0)else(54)
def _13():
    return (55)if(tm(gr(3,6),3))else(19)
def _14():
    return (26)if((gr(3,6))-(30))else(45)
def _15():
    return (18)if((gr(0,6))-(gr(0,4)))else(27)
def _16():
    return (30)if((gr(0,6))-(gr(0,4)))else(29)
def _17():
    gw(9,6,0)
    gw(0,4,1009)
    gw(0,6,9)
    gw(3,6,0)
    gw(1,6,1)
    return 18
def _18():
    sa(gr(gr(3,6),gr(0,6)))
    return 13
def _19():
    sa(48)
    v0=sp()
    sa(sp()-v0)
    sa(10)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(17)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 8
def _20():
    sp()
    sa(1)
    sa(sp()+sp());
    return 21
def _21():
    sa(1)
    sa(sp()+sp());
    return 22
def _22():
    sa(1)
    sa(sp()+sp());
    return 23
def _23():
    sa(1)
    sa(sp()+sp());
    return 24
def _24():
    sa(1)
    sa(sp()+sp());
    return 25
def _25():
    gw((gr(3,6))-(td(gr(3,6),3)),gr(0,6),sp())
    return 14
def _26():
    gw(3,6,(gr(3,6))+(1))
    return 15
def _27():
    gw(0,6,8)
    sa((0)if((gr(1,6))!=0)else(1))
    gw(1,6,(0)if((gr(1,6))!=0)else(1))
    return 0
def _28():
    gw(0,6,(gr(0,6))+(1))
    return 16
def _29():
    sa(((1)if((gr(0,7))>(gr(1,7)))else(0))+(gr(9,6)))
    gw(9,6,((1)if((gr(0,7))>(gr(1,7)))else(0))+(gr(9,6)))
    print(sp(),end="",flush=True)
    return 56
def _30():
    gw(9,6,((1)if((gr(0,7))>(gr(1,7)))else(0))+(gr(9,6)))
    gw(16,2,0)
    return 31
def _31():
    sa(15)
    sa(0)
    return 1
def _32():
    gw(3,6,(gr(1,6))*(10))
    gw(4,6,0)
    gw(5,6,1)
    gw(6,6,0)
    gw(7,6,0)
    gw(0,5,gr(gr(3,6),gr(0,6)))
    gw(5,6,(gr((gr(3,6))+(1),gr(0,6)))*(gr(5,6)))
    sp()
    return 33
def _33():
    sa((1)if((gr(0,5))>(gr(6,6)))else(0))
    return 2
def _34():
    gw(6,6,gr(0,5))
    return 35
def _35():
    sa((0)if((gr(gr(0,5),2))!=0)else(1))
    return 3
def _36():
    sa((1)if((gr(0,5))>(gr(7,6)))else(0))
    return 7
def _37():
    gw(7,6,gr(0,5))
    return 38
def _38():
    gw(gr(0,5),2,(gr(gr(0,5),2))+(1))
    sa((gr(3,6))+(2))
    gw(3,6,(gr(3,6))+(2))
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 4
def _39():
    gw(0,5,gr(gr(3,6),gr(0,6)))
    gw(5,6,(gr((gr(3,6))+(1),gr(0,6)))*(gr(5,6)))
    return 33
def _40():
    gw(3,5,0)
    gw(4,6,(((gr(15,2))*((gr(15,2))-(1)))*(256))+(gr(4,6)))
    gw(3,5,((0)if(((0)if(((gr(15,2))*(gr(16,2)))!=0)else(1))!=0)else(1))+(gr(3,5)))
    sa(14)
    sa(0)
    return 5
def _41():
    gw(4,6,((((gr(4,6))+(gr(6,6)))+((gr(7,6))*(15)))+(((0)if(((gr(3,5))-(4))!=0)else(1))*(2540)))+(((0)if(((0)if((((0)if(((16807)-(gr(5,6)))!=0)else(1))+(((0)if(((32)-(gr(5,6)))!=0)else(1))+(((0)if(((243)-(gr(5,6)))!=0)else(1))+((0)if(((1889568)-(gr(5,6)))!=0)else(1)))))!=0)else(1))!=0)else(1))*(2550)))
    gw(gr(1,6),7,gr(4,6))
    sp()
    sa((0)if((gr(1,6))!=0)else(1))
    gw(1,6,(0)if((gr(1,6))!=0)else(1))
    return 6
def _42():
    gw(16,2,0)
    return 31
def _43():
    sa(sr())
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sp()*sp());
    sa(256)
    sa(sp()*sp());
    sa(gr(4,6))
    sa(sp()+sp());
    gw(4,6,sp())
    sa(sr())
    sa(sr())
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    sa(sp()+sp());
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()*sp());
    sa((0)if(sp()!=0)else(1))
    sa((0)if(sp()!=0)else(1))
    sa(gr(3,5))
    sa(sp()+sp());
    gw(3,5,sp())
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((0)if(sp()!=0)else(1))
    return 5
def _44():
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
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((0)if(sp()!=0)else(1))
    return 1
def _45():
    gw((gr(3,6))-(td(gr(3,6),3)),gr(0,6),32)
    gw(3,6,0)
    gw(0,6,(gr(0,6))+(1))
    return 15
def _46():
    sa(sr())
    sa(27)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 9
def _47():
    sp()
    return 21
def _48():
    sa(sr())
    sa(33)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 10
def _49():
    sp()
    return 22
def _50():
    sa(sr())
    sa(26)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 11
def _51():
    sp()
    return 23
def _52():
    sa(sr())
    sa(36)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 12
def _53():
    sp()
    return 24
def _54():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sp()
    return 25
def _55():
    sa(65)
    v0=sp()
    sa(sp()-v0)
    return 25
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55]
c=17
while c<56:
    c=m[c]()