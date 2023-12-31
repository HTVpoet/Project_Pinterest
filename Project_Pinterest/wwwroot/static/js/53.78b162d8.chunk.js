"use strict";(self.webpackChunkpicsta=self.webpackChunkpicsta||[]).push([[53],{85386:function(e,t,n){n.d(t,{Z:function(){return v}});n(47313);var i=n(82403),r=n(97890),l=n(73428),s=n(16957),a=n(93405),o=n(61113),c=n(35898),d=n(48119),u=n(82500),x=n(48175),h=n(46417);function m(e){var t=e.userId,n=e.id,i=e.title,m=e.author,v=e.image,Z=(0,r.s0)();return(0,h.jsxs)(l.Z,{sx:{maxWidth:345,boxShadow:3,cursor:"pointer"},children:[(0,h.jsx)(s.Z,{component:"img",image:v,alt:i,sx:{width:"100%",height:"auto",objectFit:"contain"},onClick:function(){return Z("".concat(x.v.general.pin.detail,"/").concat(n))}}),(0,h.jsxs)(a.Z,{sx:{textAlign:"left"},children:[(0,h.jsx)(o.Z,{gutterBottom:!0,variant:"h5",component:"div",children:i}),(0,h.jsxs)(c.Z,{onClick:function(){return Z("".concat(x.v.general.profile.user,"/").concat(t))},direction:"row",alignItems:"center",spacing:2,children:[(0,h.jsx)(d.Z,{src:null===m||void 0===m?void 0:m.photoURL,alt:null===m||void 0===m?void 0:m.displayName,color:null!==m&&void 0!==m&&m.photoURL?"default":(0,u.Z)(null===m||void 0===m?void 0:m.displayName).color,children:(0,u.Z)(null===m||void 0===m?void 0:m.displayName).name}),(0,h.jsx)(o.Z,{variant:"body2",color:"text.secondary",children:m})]})]})]})}function v(e){var t=e.items;return(0,h.jsx)(i.ZP,{columns:{xs:1,sm:2,md:3},spacing:2,children:t.map((function(e,t){return(0,h.jsx)(m,{userId:e.dataResponseUser.id,id:e.id,title:e.title,author:e.dataResponseUser.fullName,image:e.imageUrl},t)}))})}},85053:function(e,t,n){n.r(t),n.d(t,{default:function(){return N}});var i=n(15861),r=n(70885),l=n(64687),s=n.n(l),a=n(47313),o=n(73428),c=n(61113),d=n(43265),u=n(82295),x=n(57829),h=n(48119),m=n(9019),v=n(69099),Z=n(97890),f=n(29466),j=n(71361),g=n(11338),p=n(85386),b=n(47225),w=n(48175),y=n(54285),P=n(52643),k=n(46417),C=function(e){var t=e.number,n=e.label;return(0,k.jsxs)(o.Z,{sx:{width:150,height:100,display:"flex",flexDirection:"column",alignItems:"center",justifyContent:"center"},children:[(0,k.jsx)(c.Z,{variant:"h6",children:t}),(0,k.jsx)(c.Z,{variant:"subtitle2",children:n})]})};function N(){var e=(0,y.Z)().user,t=(0,a.useState)([]),n=(0,r.Z)(t,2),l=n[0],o=n[1],N=(0,g.Z)().themeStretch,S=(0,Z.s0)(),U=(0,a.useState)(0),F=(0,r.Z)(U,2),I=F[0],R=F[1],A=(0,a.useState)(0),L=(0,r.Z)(A,2),O=L[0],W=L[1],B=(0,a.useState)(0),D=(0,r.Z)(B,2),E=D[0],z=D[1];return(0,a.useEffect)((0,i.Z)(s().mark((function t(){var n;return s().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,(0,P.gR)(e.id);case 2:n=t.sent,o(n.posts),z(n.numberOfFollower),R(n.postNumber),W(n.numberOfFollowing);case 7:case"end":return t.stop()}}),t)}))),[]),(0,k.jsx)(j.Z,{title:"Profile",children:(0,k.jsxs)(d.Z,{maxWidth:!N&&"xl",children:[(0,k.jsx)(u.Z,{elevation:3,sx:{p:3,mb:5,bgcolor:"background.default",display:"flex",flexDirection:"column",alignItems:"center"},children:(0,k.jsxs)(x.Z,{sx:{textAlign:"center",my:4},children:[(0,k.jsx)(h.Z,{alt:null===e||void 0===e?void 0:e.fullName,src:null===e||void 0===e?void 0:e.avatarUrl,sx:{width:140,height:140,mx:"auto"}}),(0,k.jsx)(c.Z,{variant:"h4",sx:{mt:2},children:null===e||void 0===e?void 0:e.fullName}),(0,k.jsx)(c.Z,{gutterBottom:!0,children:null===e||void 0===e?void 0:e.email}),(0,k.jsxs)(m.ZP,{container:!0,spacing:2,justifyContent:"center",children:[(0,k.jsx)(m.ZP,{item:!0,children:(0,k.jsx)(C,{number:I,label:"Pics"})}),(0,k.jsx)(m.ZP,{item:!0,children:(0,k.jsx)(C,{number:E,label:"Followers"})}),(0,k.jsx)(m.ZP,{item:!0,children:(0,k.jsx)(C,{number:O,label:"Following"})})]}),(0,k.jsx)(x.Z,{sx:{mt:3},children:(0,k.jsx)(v.Z,{onClick:function(){return S(w.v.general.profile.edit)},variant:"contained",sx:{mr:1},children:"Edit"})})]})}),l.length?(0,k.jsx)(p.Z,{items:l}):(0,k.jsxs)(x.Z,{sx:{maxWidth:480,margin:"auto",textAlign:"center"},children:[(0,k.jsx)(c.Z,{variant:"h3",paragraph:!0,children:"No Pics found."}),(0,k.jsx)(c.Z,{sx:{color:"text.secondary"},children:"Start Creating Pics"}),(0,k.jsx)(b.A2,{sx:{height:260,my:{xs:5,sm:10}}}),(0,k.jsx)(v.Z,{to:"/",size:"large",variant:"contained",component:f.OL,children:"Create Pic"})]})]})})}}}]);