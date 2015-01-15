# compiled with BefunCompile v1.0.2 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABAC9VMtqw0AM/JUhySnGRVp5X6GYfkhJevPVp3x/R17ogxjakrjCOCvh7OxoRns4jNGOEJlFJu0Df1XmUWWy4ymw1E072fUxdsdX7T4LHb9Ysln9feKfmPba768XLk4fWzG/4jZyXCnivFb8ZTzf5Gu4NSINN9W1Lx93Eg/NGDJKuHvzEYe/nFYLLKJkqHzdhGKHvom2iN2EbYvQUT7P2xr9Sd7G/fnSj99Ep8RN3iY3zTK3XHR6egkCGZwvWadVre8Se03uxrdCFMHcYGKwW623iVIgATkjG4SUDSn/B26t3l62OvAACZqQBfV+m/0Ug/oTEmJCMQyCIg5ttj1uQQ4ORGsZF9lZV3agbogb6ShCD97tEDEYqiIG1Iyo0M1sxpaqOlnq29zFmyRzqKl78XXcxmZklxeCtqCQICtkHQuiIGTvNoV4ePjgJPcz2ZXqbeccmSzEE1L1q4xmM30wriNSzbJQ4wjXZY6K41bzJvhJljstPNTh73sJfUqABwAA"
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<120 and y<16):
        return g[y*120 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<120 and y<16):
        g[y*120 + x]=v;
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
    gw(0,0,15)
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