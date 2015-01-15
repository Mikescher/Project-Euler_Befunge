# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="Ah+LCAAAAAAABACT7+ZgAAEWhrfXHLOvOEg0PNxvdObW6ba3dTfvKrRsqvj47uLhTbqvjAK0ZLveZdbvEd4b4bo6IKr1uSKPj5HnDOeKYp/JT4327ty9127P/ylx9fss7yw9alJfXvxjRpzaA3tzZoZBBh54LjleUpNx8OjifXw/jG//UeR3Npf/veL1nlOfC0VL5QLDX6+wfGr469Z25VMGZZ/3SS/698E0P3jLUk2zwO2vNWrNt2VWx1je3pp4s1x1/9nu/Gx///2ODx6y/H9TN0X/++bVQq+FJur5bX09XfXX3UjpY2Vm7nFXbvTExicFJ10oruC7fSVrdlT7fv2C3M8mR3d6J3dp7F69Pjv9+Gnx/V5lWSftfMXPx9u+rmvYv3G/+PO7X/jvF+35f1Y2i/f/Mv3FHVz7ExKZGADdxMcoswEAAA=="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<1000 and y<156):
        return g[y*1000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<1000 and y<156):
        g[y*1000 + x]=v;
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
    return (7)if(sp()!=0)else(8)
def _1():
    return (10)if(sp()!=0)else(9)
def _2():
    return (6)if(sp()!=0)else(11)
def _3():
    return (12)if(sp()!=0)else(13)
def _4():
    return (12)if(sp()!=0)else(14)
def _5():
    gw(1,0,1000)
    gw(2,0,150)
    gw(0,0,150000)
    gw(3,0,2)
    gw(0,1,32)
    gw(1,1,32)
    gw(5,0,((gr(1,0))*(10))+(1))
    return 6
def _6():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(1),88)
    sa((gr(3,0))+(gr(3,0)))
    sa((1)if((gr(0,0))>((gr(3,0))+(gr(3,0))))else(0))
    return 0
def _7():
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
    return 0
def _8():
    sp()
    return 9
def _9():
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
    return 1
def _10():
    sa((1)if((gr(0,0))>(gr(3,0)))else(0))
    return 2
def _11():
    gw(3,0,0)
    gw(4,0,0)
    return 12
def _12():
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
    return 3
def _13():
    sa(gr(5,0))
    sa((gr(4,0))+(1))
    gw(4,0,(gr(4,0))+(1))
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(1),48)
    v0=sp()
    sa(sp()-v0)
    return 4
def _14():
    print(gr(3,0),end="",flush=True)
    return 15
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14]
c=5
while c<15:
    c=m[c]()