# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABADtl81uG0cQhF+FYOyLGDv9O90txEIeJFBy45UnPX++kS0gAYw49vKYAYYL7nC3pqurasDzy1nklvHwqFzSHh4eTW4PLrfOS8hNkrmYxWy5nRgvp2PjSVOuvPNpyRW06/vf+fhlLteznD88cFMvjyzzow/B/Onlj8eW659c3z3l6yqb8s8rp2Fjp6eSq1w/8tlvj5w/nX/mqY+//RP7+T/u8Vfmu+975Guv+KHx1J853/xQ7+XRTl9IOr2xxMpc5LZOb2R9qfr5Rzb79Y2+3X2m9xe9Sv37zw+M797z3Xfw//j7KNdVWitd3WVZjI5Zqs6qCFtZUWGe6XslxuM45qxpTxNXq4qU5bbMJ6tdW5TV4NJrorpTO/w4ZmcvzSXVo2oUEpORk6LlNdnuOmmdbtItCQHHMdUyhGqgULPTvJeTsXxZ4zYyFA6oQbRLwHF9+53fGmv1rBVNZRFpe9JhitTOFeLCdhQGtIz9uOoduF1mNo00zL2BaPV0X1ZraVhbywpGs69NQsUcx3Tx7JGyWTCJNulthFQhJBj2VslN+rjULAH7OGYhFgsr2Ov2gcmpET53C8d0tnantoJaxqvugIkBrRxrCgVBKo5QM8GRwS5kKrfK0FniFrR0D6+kZQcsIpRVeGGJOuxSMiaK4B7CjVC2ZkoyzB10m76mWmG0OtArxsGhqfAKxcteLaOzF/lm0XYck4KoINQroVmok7QbMVSLaLa0emEhjfRUEYLwDpima3nBJmolc/CNCIIhB8J3FqLZoMOVjWYX3T6OqWuLtjRqhr6FDabEpstjJTGPX8l23UHBQtDkO2DWq93JeV4cuSASgS6kuggE8kkNDxEPRPKCgrhDP/EmHjTjQNuqNVSqe2wvSlK3FgRPKCSTCSF9HJOs4bgS7yTOKRSYIPoGl75mbW/OSQ1yEGkNwXEcs+FVCDyURADs1pG7lQGSCDrCnpwCMLzPO852uUM/ZeuRPIhN7sQ+xkDEFbatSSf5P4GQk8AlFjBPHscspRBbQ6XddFX2YUJ9TRoJCras5OA0Ifg4S3HPccy/AFjBplkkDQAA"
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<116 and y<29):
        return g[y*116 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<116 and y<29):
        g[y*116 + x]=v;
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
    return (8)if(sp()!=0)else(9)
def _1():
    return (10)if(sp()!=0)else(17)
def _2():
    return (11)if(sp()!=0)else(12)
def _3():
    return (6)if(sp()!=0)else(13)
def _4():
    return (15)if(((gr(7,0))-(8))-(gr(4,0)))else(16)
def _5():
    gw(0,0,118)
    gw(1,0,20)
    gw(2,0,50)
    gw(3,0,1000)
    gw(4,0,13)
    gw(5,0,0)
    gw(6,0,0)
    gw(7,0,0)
    gw(8,0,0)
    return 6
def _6():
    gw(6,0,gr(5,0))
    sa((1)*((gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+(9)))-(48)))
    return 7
def _7():
    sa((gr(6,0))+(1))
    gw(6,0,(gr(6,0))+(1))
    sa(gr(5,0))
    v0=sp()
    sa(sp()-v0)
    sa(gr(4,0))
    v0=sp()
    sa(sp()-v0)
    return 0
def _8():
    sa((gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+(9)))-(48))
    sa(sp()*sp());
    return 7
def _9():
    sa(sr())
    sa(gr(8,0))
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 1
def _10():
    gw(8,0,sp())
    gw(6,0,0)
    return 11
def _11():
    gw((gr(6,0))+(9),0,(gr(tm((gr(6,0))+(gr(5,0)),gr(2,0)),(td((gr(6,0))+(gr(5,0)),gr(2,0)))+(9)))-(48))
    sa((gr(6,0))+(1))
    gw(6,0,(gr(6,0))+(1))
    sa(gr(4,0))
    v0=sp()
    sa(sp()-v0)
    return 2
def _12():
    sa((gr(5,0))+(1))
    gw(5,0,(gr(5,0))+(1))
    sa(gr(3,0))
    v0=sp()
    sa(sp()-v0)
    return 3
def _13():
    gw(7,0,9)
    return 14
def _14():
    print(gr(gr(7,0),0),end="",flush=True)
    return 4
def _15():
    gw(7,0,(gr(7,0))+(1))
    return 14
def _16():
    print(chr(61),end="",flush=True)
    print(gr(8,0),end="",flush=True)
    return 18
def _17():
    sp()
    return 12
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17]
c=5
while c<18:
    c=m[c]()