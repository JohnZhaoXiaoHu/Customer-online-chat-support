//���밲װ��signalr��
import * as signalR from '@aspnet/signalr'
const signal = new signalR.HubConnectionBuilder()
    .withUrl('http://localhost:52970/chathub')//��������ַ
    .build()
export default {
    install: function (Vue) {
        Vue.prototype.signalr = signal
    }
}