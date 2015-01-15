# compiled with BefunCompile v1.0.2 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABADNkDtvxCAMgP8KSegSmivOY6iFrFs6V8qMckNVsTIx8eNrSKqQi3Tq1PYbjJ/4EZpvxP8mHAYNfz3OEbNez8M4GXG+aDGtAlPUHdYw57WMuCf43mrc/RR2uXlkMoJ1PZ7LS6j+/KjbATz1IwsNHRAO4FqLI7iuWW6SLGjPAUs4TerJsnjBHADt2GgVxxFUcrHHJjXcZEomIaDDyG1yKUbC3lWRwPY+f1NFQTkvpVEq466s8yyQmg/Z4vHiwy1Wlh/k3GHL60iSuP0hm12umKA25OOL/iZSUn6pcGl67Sors7EIumTlmuVzQtTz+zy/1eYL/qbl3PYDAAA="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<169 and y<6):
        return g[y*169 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<169 and y<6):
        g[y*169 + x]=v;
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
    return (14)if(sp()!=0)else(15)
def _1():
    return (17)if(sp()!=0)else(18)
def _2():
    return (19)if(sp()!=0)else(20)
def _3():
    return (16)if(sp()!=0)else(21)
def _4():
    return (38)if(sp()!=0)else(22)
def _5():
    return (24)if(sp()!=0)else(37)
def _6():
    return (25)if(sp()!=0)else(35)
def _7():
    return (26)if(sp()!=0)else(23)
def _8():
    return (34)if(sp()!=0)else(27)
def _9():
    return (29)if(sp()!=0)else(30)
def _10():
    return (13)if(sp()!=0)else(31)
def _11():
    return (32)if(sp()!=0)else(33)
def _12():
    gw(3,1,9999)
    gw(4,1,2)
    return 13
def _13():
    sa(-1)
    sa((1)*(gr(3,1)))
    sa(1)
    sa((1)-(gr(4,1)))
    return 0
def _14():
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(gr(3,1))
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(gr(4,1))
    v0=sp()
    sa(sp()-v0)
    return 0
def _15():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 16
def _16():
    gw(1,0,sp())
    sa(-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 17
def _17():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 1
def _18():
    sp()
    return 19
def _19():
    sa((gr(1,0))*(10))
    sa(sp()+sp());
    gw(1,0,sp())
    sa(sr())
    sa(1)
    sa(sp()+sp());
    return 2
def _20():
    sp()
    sa(gr(1,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(1)
    sa(sp()+sp());
    return 3
def _21():
    sp()
    sa(sr())
    sa(9)
    sa(9)
    return 4
def _22():
    sp()
    sa(sr())
    return 23
def _23():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 5
def _24():
    sa(sr())
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 6
def _25():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 7
def _26():
    sp()
    sa(9)
    sa(9)
    return 8
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
    return 28
def _28():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sp()
    return 9
def _29():
    print(sp(),end="",flush=True)
    return 39
def _30():
    sp()
    sa((gr(4,1))-(1))
    gw(4,1,(gr(4,1))-(1))
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return 10
def _31():
    sa((gr(3,1))-(1))
    gw(3,1,(gr(3,1))-(1))
    return 11
def _32():
    gw(4,1,5)
    return 13
def _33():
    sa(69)
    sa(82)
    sa(82)
    sa(79)
    print(chr(82),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    return 39
def _34():
    sa(sr())
    sa(2)
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
    return 8
def _35():
    sp()
    return 36
def _36():
    sp()
    sa(0)
    return 28
def _37():
    sp()
    return 36
def _38():
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
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38]
c=12
while c<39:
    c=m[c]()