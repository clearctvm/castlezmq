﻿namespace Castle.Zmq
{
	using System;

	public interface IZmqContext : IDisposable
	{
		IZmqSocket CreateSocket(SocketType type);

		IZmqSocket CreateSocket(SocketType type, int rcvTimeoutInMilliseconds);

		event Action Disposing;
		event Action Disposed;
	}
}