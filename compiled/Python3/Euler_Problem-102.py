#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADVnbuuJMdyRX+lL3StmS6h8p1JEBf6A7myKHnHHYuWPl6xdtShBEjWbksH4nA4V0xWd2VGxmM/7rv9+sdd+GW0X3eNv1r7VXr8QW1fpX2dn1+/jfPj"
  + "+ts//fnvv/Wdv3m9fjv1Z89/+PPP8jXGj+tr3F+/v75//vP68ePHHmN8/9Efv1r9Wb5a/f1X6+VXa6/71/jVxs/y+u2rjR9frX+19vffX3+Of/TxdY+vq44//lrvH3f7"
  + "+ud/ef0fP7Fwv8r999//ZNH4+fs/vX7++DlGLHf92PP3rz9+9fvnj9/iCX//u35iufho5edv8cH/+F/rff/m+8n/0dpXb18/Rvsav+LRXjzbbz/iP1D++Lf8eb3+zP9A"
  + "fBVNv7m/Rv3V688f8Wf55/ERx53/S//Vy88fz//79fv/+I//q370H+2/an4N8dePFv+x+G389eNn7/GCvnqPP+1fNf52Df0Jv73jf/jz//6S7p9f7f7bz59/+4+fX/Ep"
  + "+vzq6z/ib3f8Mu5ffV0/vnqJ//vBp+3xJ5M/+e/v4f/Dz9X6/e5nvOOrau/rlPu9W/zT6ctbr6zx7uV99Rq/rNLfY/X3Nfswn2/09V6lvq82aqx13mew8J7eer2c97Vn"
  + "PNJu7znuWPecd1nFW+4Vn5MFD8+34mtr97ue+b7qMddbLZ5t3fW9a7yP1eNdzM03WL31zirvNev71FhprXi0ORtv23u/ZfIW7ves+913LLnvxec3X8drxl458ULneK87"
  + "9t6Otz3M746fWuKZeryBPnkb5d0re+d217tKbJg2znvOHU9560Vv/hPdWq/HcTuxZU4sV+N0rBlbcJsvg+fjW1vxInaLBePpaonPXtztHOvFy706H7GxYwgK4x7vmVeF"
  + "sV4c29gk4936eWv/rThwc5ufuMWpGO8xY8u0GTsnPvGY9tvlfMT+5Y3WiAmtxum9+7su7+Wy3qrsjjlj0XjT88RLYQO68e90AvKMR6q8jPZefb/LNlcj/sV5O/u9S3yP"
  + "8XFb4Zx0+8RFIKnxvc2IpfG5CTSlc1CGuQNbBNBBSDmEvPiod4nobL+O1+C2IB4sfYHcTATXy76PCndHJ+Cf+PYiuMwIMpcdsuZq7xa75YpVI4skxHBEbvcT9/qEqX3z"
  + "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")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<1009):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<1009):
        g[y*80 + x]=v;
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
    gw(0,3,0)
    gw(1,3,0)
    return 1
def _1():
    gw(5,3,0)
    gw(2,3,0)
    gw(3,3,0)
    gw(4,3,1)
    return 2
def _2():
    global t0
    t0=gr(gr(2,3),gr(1,3)+9)

    return (5)if(gr(gr(2,3),gr(1,3)+9)!=45)else(3)
def _3():
    gw(4,3,-1)
    return 4
def _4():
    gw(2,3,gr(2,3)+1)
    return 2
def _5():
    global t0
    return (8)if(t0!=32)else(6)
def _6():
    global t0
    gw(gr(5,3),5,gr(3,3)*gr(4,3))
    gw(0,4,((gr(4,5)-gr(0,5))*(gr(4,5)-gr(0,5)))+((gr(5,5)-gr(1,5))*(gr(5,5)-gr(1,5))))
    gw(1,4,((gr(4,5)-gr(0,5))*(gr(2,5)-gr(0,5)))+((gr(5,5)-gr(1,5))*(gr(3,5)-gr(1,5))))
    gw(2,4,((gr(4,5)-gr(0,5))*gr(0,5))+((gr(5,5)-gr(1,5))*gr(1,5)))
    gw(3,4,((gr(2,5)-gr(0,5))*(gr(2,5)-gr(0,5)))+((gr(3,5)-gr(1,5))*(gr(3,5)-gr(1,5))))
    gw(4,4,((gr(2,5)-gr(0,5))*gr(0,5))+((gr(3,5)-gr(1,5))*gr(1,5)))
    gw(5,4,(gr(1,4)*gr(4,4))-(gr(3,4)*gr(2,4)))
    gw(6,4,(gr(1,4)*gr(2,4))-(gr(0,4)*gr(4,4)))
    gw(7,4,(gr(0,4)*gr(3,4))-(gr(1,4)*gr(1,4)))
    gw(0,3,((0)if(((1)if(0>gr(5,4))else(0))+((1)if(0>gr(6,4))else(0))+((1)if(gr(7,4)<=(gr(6,4)+gr(5,4)))else(0))!=0)else(1))+gr(0,3))
    t0=gr(1,3)-999
    gw(1,3,gr(1,3)+1)

    return (1)if((t0)!=0)else(7)
def _7():
    print(gr(0,3),end=" ",flush=True)
    return 11
def _8():
    global t0
    return (10)if(t0!=44)else(9)
def _9():
    sa(gr(3,3)*gr(4,3))
    sa(gr(5,3))
    gw(5,3,gr(5,3)+1)
    sa(5)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(3,3,0)
    gw(4,3,1)
    return 4
def _10():
    global t0
    t0=t0-48
    t0=t0+(gr(3,3)*10)
    gw(3,3,t0)
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10]
c=0
while c<11:
    c=m[c]()
