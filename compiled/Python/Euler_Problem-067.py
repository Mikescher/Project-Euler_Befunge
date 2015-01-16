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
    if(x>=0 and y>=0 and x<299 and y<101):
        return g[y*299 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<299 and y<101):
        g[y*299 + x]=v;
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
    return (16)if(sp()!=0)else(7)
def _1():
    return (15)if(sp()!=0)else(8)
def _2():
    return (9)if(sp()!=0)else(12)
def _3():
    return (9)if(sp()!=0)else(13)
def _4():
    return (14)if((1)if(((gr(gr(1,0),(gr(2,0))+(2)))-(gr((gr(1,0))+(1),(gr(2,0))+(2))))>(0))else(0))else(10)
def _5():
    gw(0,0,100)
    gw(2,0,(gr(0,0))-(1))
    gw(1,0,0)
    gw(gr(1,0),(gr(2,0))+(1),(((gr((gr(1,0))*(3),(gr(2,0))+(1)))-(48))*(10))+((gr(((gr(1,0))*(3))+(1),(gr(2,0))+(1)))-(48)))
    sp()
    sp()
    return 6
def _6():
    sa((gr(1,0))+(1))
    gw(1,0,(gr(1,0))+(1))
    sa(gr(2,0))
    v0=sp()
    sa(sp()-v0)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return 0
def _7():
    sa(gr(2,0))
    gw(2,0,(gr(2,0))-(1))
    gw(1,0,0)
    return 1
def _8():
    sa((gr(0,0))-(2))
    gw(1,0,(gr(0,0))-(2))
    gw(2,0,sp())
    return 9
def _9():
    sa(gr(gr(1,0),(gr(2,0))+(1)))
    sa(gr(gr(1,0),(gr(2,0))+(2)))
    sa((gr(gr(1,0),(gr(2,0))+(2)))-(gr((gr(1,0))+(1),(gr(2,0))+(2))))
    return 4
def _10():
    v0=sp()
    sa(sp()-v0)
    return 11
def _11():
    sa(sp()+sp());
    gw(gr(1,0),(gr(2,0))+(1),sp())
    sa(gr(1,0))
    gw(1,0,(gr(1,0))-(1))
    return 2
def _12():
    sa(gr(2,0))
    sa((gr(2,0))-(1))
    gw(2,0,(gr(2,0))-(1))
    gw(1,0,sp())
    return 3
def _13():
    print(gr(0,1),end="",flush=True)
    return 17
def _14():
    sp()
    return 11
def _15():
    gw(gr(1,0),(gr(2,0))+(1),(((gr((gr(1,0))*(3),(gr(2,0))+(1)))-(48))*(10))+((gr(((gr(1,0))*(3))+(1),(gr(2,0))+(1)))-(48)))
    return 6
def _16():
    gw(gr(1,0),(gr(2,0))+(1),(((gr((gr(1,0))*(3),(gr(2,0))+(1)))-(48))*(10))+((gr(((gr(1,0))*(3))+(1),(gr(2,0))+(1)))-(48)))
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16]
c=5
while c<17:
    c=m[c]()