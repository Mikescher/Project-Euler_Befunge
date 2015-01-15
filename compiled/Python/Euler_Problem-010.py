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
    if(x>=0 and y>=0 and x<2000 and y<1007):
        return g[y*2000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<2000 and y<1007):
        g[y*2000 + x]=v;
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
    return (18)if(sp()!=0)else(7)
def _1():
    return (9)if(sp()!=0)else(10)
def _2():
    return (12)if(sp()!=0)else(11)
def _3():
    return (8)if(sp()!=0)else(13)
def _4():
    return (16)if(sp()!=0)else(15)
def _5():
    return (14)if(sp()!=0)else(17)
def _6():
    gw(1999,1000,35)
    sa(1999999)
    sa(1999999)
    return 0
def _7():
    gw(1,0,2000)
    gw(2,0,2000)
    gw(0,0,2000000)
    gw(3,0,2)
    gw(0,1,32)
    gw(1,1,32)
    gw(5,0,((gr(1,0))*(10))+(1))
    return 8
def _8():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(1),88)
    sa((gr(3,0))+(gr(3,0)))
    sa((1)if((gr(0,0))>((gr(3,0))+(gr(3,0))))else(0))
    return 1
def _9():
    sa(sr())
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(gr(3,0))
    sa(sp()+sp());
    sa(sr())
    sa(gr(0,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 1
def _10():
    sp()
    return 11
def _11():
    sa((gr(3,0))+(1))
    gw(3,0,(gr(3,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(32)
    v0=sp()
    sa(sp()-v0)
    return 2
def _12():
    sa((1)if((gr(0,0))>(gr(3,0)))else(0))
    return 3
def _13():
    gw(3,0,0)
    gw(4,0,0)
    return 14
def _14():
    sa((gr(3,0))+(1))
    gw(3,0,(gr(3,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(88)
    v0=sp()
    sa(sp()-v0)
    return 4
def _15():
    gw(4,0,(gr(3,0))+(gr(4,0)))
    return 16
def _16():
    sa((gr(0,0))-(gr(3,0)))
    return 5
def _17():
    print(gr(4,0),end="",flush=True)
    return 19
def _18():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(35)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(2000)
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2000)
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18]
c=6
while c<19:
    c=m[c]()