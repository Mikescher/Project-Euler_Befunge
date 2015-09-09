#!/usr/bin/env python3
# compiled with BefunCompile v1.0.8 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABADtl81uG0cQhF+FYOyLGDv9O90txEIeJFBy45UnPX++kS0gAYw49vKYAYYL7nC3pqurasDzy1nklvHwqFzSHh4eTW4PLrfOS8hNkrmYxWy5nRgvp2Pj"
  + "SVOuvPNpyRW06/vf+fhlLteznD88cFMvjyzzow/B/Onlj8eW659c3z3l6yqb8s8rp2Fjp6eSq1w/8tlvj5w/nX/mqY+//RP7+T/u8Vfmu+975Guv+KHx1J853/xQ7+XR"
  + "Tl9IOr2xxMpc5LZOb2R9qfr5Rzb79Y2+3X2m9xe9Sv37zw+M797z3Xfw//j7KNdVWitd3WVZjI5Zqs6qCFtZUWGe6XslxuM45qxpTxNXq4qU5bbMJ6tdW5TV4NJrorpT"
  + "O/w4ZmcvzSXVo2oUEpORk6LlNdnuOmmdbtItCQHHMdUyhGqgULPTvJeTsXxZ4zYyFA6oQbRLwHF9+53fGmv1rBVNZRFpe9JhitTOFeLCdhQGtIz9uOoduF1mNo00zL2B"
  + "aPV0X1ZraVhbywpGs69NQsUcx3Tx7JGyWTCJNulthFQhJBj2VslN+rjULAH7OGYhFgsr2Ov2gcmpET53C8d0tnantoJaxqvugIkBrRxrCgVBKo5QM8GRwS5kKrfK0Fni"
  + "FrR0D6+kZQcsIpRVeGGJOuxSMiaK4B7CjVC2ZkoyzB10m76mWmG0OtArxsGhqfAKxcteLaOzF/lm0XYck4KoINQroVmok7QbMVSLaLa0emEhjfRUEYLwDpima3nBJmol"
  + "c/CNCIIhB8J3FqLZoMOVjWYX3T6OqWuLtjRqhr6FDabEpstjJTGPX8l23UHBQtDkO2DWq93JeV4cuSASgS6kuggE8kkNDxEPRPKCgrhDP/EmHjTjQNuqNVSqe2wvSlK3"
  + "FgRPKCSTCSF9HJOs4bgS7yTOKRSYIPoGl75mbW/OSQ1yEGkNwXEcs+FVCDyURADs1pG7lQGSCDrCnpwCMLzPO852uUM/ZeuRPIhN7sQ+xkDEFbatSSf5P4GQk8AlFjBP"
  + "HscspRBbQ6XddFX2YUJ9TRoJCras5OA0Ifg4S3HPccy/AFjBplkkDQAA")
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
    gw(0,0,118)
    gw(1,0,20)
    gw(2,0,50)
    gw(3,0,1000)
    gw(4,0,13)
    gw(5,0,0)
    gw(6,0,0)
    gw(7,0,0)
    gw(8,0,0)
    return 1
def _1():
    global t0
    gw(6,0,gr(5,0))
    t0=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48
    return 2
def _2():
    global t1
    t1=gr(6,0)+1
    gw(6,0,gr(6,0)+1)
    t1=t1-gr(5,0)
    t1=t1-gr(4,0)
    return (3)if((t1)!=0)else(4)
def _3():
    global t0
    t0=t0*(gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48)
    return 2
def _4():
    return (10)if(t0>gr(8,0))else(5)
def _5():
    global t0
    t0=gr(5,0)+1
    gw(5,0,gr(5,0)+1)
    t0=t0-gr(3,0)
    return (1)if((t0)!=0)else(6)
def _6():
    gw(7,0,9)
    return 7
def _7():
    print(gr(gr(7,0),0),end="",flush=True)
    return (9)if(gr(7,0)-8!=gr(4,0))else(8)
def _8():
    print(chr(61),end="",flush=True)
    print(gr(8,0),end="",flush=True)
    return 13
def _9():
    gw(7,0,gr(7,0)+1)
    return 7
def _10():
    global t0
    gw(8,0,t0)
    gw(6,0,0)
    return 11
def _11():
    global t0
    gw(gr(6,0)+9,0,gr(tm(gr(6,0)+gr(5,0),gr(2,0)),(td(gr(6,0)+gr(5,0),gr(2,0)))+9)-48)
    t0=gr(6,0)+1
    gw(6,0,gr(6,0)+1)
    t0=t0-gr(4,0)
    return 12
def _12():
    global t0
    return (11)if((t0)!=0)else(5)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()