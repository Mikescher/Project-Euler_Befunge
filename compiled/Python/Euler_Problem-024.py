# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABACdUDGOAyEM/AqBrVgRMbtc7oKQdQ+xNlesREuFUvD4mCVpI+WmsEdG4xlcPZY1fF2+f67qY5De911bi/q5VtWC5VoAl/4hfgWoNKxHTU/SN9LgxHBcj2lBmJEREi3IEXOj1plninDRbLeJLB89NhGuKApBirAckC2Q/07t6Ty9CTVhk9acvmuVfeTESOI7cnX89nTvUI93wsw9CsZwk4M5+cDSj2Y7CxlrBs7Fs3ix016LHxmnDJSZlBHDbYgfFCr43OgBAAA="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<61 and y<8):
        return g[y*61 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<61 and y<8):
        g[y*61 + x]=v;
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
    return (11)if(sp()!=0)else(26)
def _1():
    return (12)if(sp()!=0)else(13)
def _2():
    return (14)if(sp()!=0)else(15)
def _3():
    return (25)if(sp()!=0)else(16)
def _4():
    return (18)if(sp()!=0)else(19)
def _5():
    return (24)if(sp()!=0)else(21)
def _6():
    return (22)if(sp()!=0)else(23)
def _7():
    return (0)if((gr(2,1))+(1))else(10)
def _8():
    gw(1,1,999999)
    gw(2,1,9)
    return 9
def _9():
    sa(gr(2,1))
    return 7
def _10():
    sp()
    return 27
def _11():
    sa(0)
    sa(gr(2,1))
    sa((gr(2,1))-(1))
    sa((gr(2,1))-(1))
    return 1
def _12():
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 1
def _13():
    sp()
    return 14
def _14():
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 2
def _15():
    sp()
    sa(sr())
    return 3
def _16():
    gw(3,1,1)
    gw(4,1,1)
    sp()
    return 17
def _17():
    sa((0)if(((1)if(((gr(3,1))*(gr(4,1)))>(gr(1,1)))else(0))!=0)else(1))
    return 4
def _18():
    gw(4,1,(gr(4,1))+(1))
    return 17
def _19():
    sa(gr(4,1))
    return 20
def _20():
    sa(1)
    sa((gr(1,0))-(120))
    return 5
def _21():
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 6
def _22():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(120)
    v0=sp()
    sa(sp()-v0)
    return 5
def _23():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(48)
    v0=sp()
    sa(sp()-v0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(120)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(1,1,(gr(1,1))-((gr(3,1))*((gr(4,1))-(1))))
    gw(2,1,(gr(2,1))-(1))
    print(sp(),end="",flush=True)
    return 9
def _24():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 21
def _25():
    gw(3,1,sp())
    gw(4,1,1)
    return 17
def _26():
    sa(1)
    return 20
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26]
c=8
while c<27:
    c=m[c]()