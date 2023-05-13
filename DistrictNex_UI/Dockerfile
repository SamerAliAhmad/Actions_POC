FROM node:18 as builder

WORKDIR /app
COPY ["./", "./"]

RUN npm set progress=false && npm install --silent
RUN npm run build

FROM nginx:latest

COPY ingress-controller/nginx/nginx.conf /etc/nginx/nginx.conf
COPY ingress-controller/nginx/conf.d/default.conf /etc/nginx/conf.d/default.conf

RUN rm -rf /usr/share/nginx/html/*
COPY --from=builder /app/dist/districtnex /usr/share/nginx/html

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
