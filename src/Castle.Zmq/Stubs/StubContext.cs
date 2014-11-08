﻿namespace Castle.Zmq.Stubs
{
	using System;
	using System.Collections.Generic;

	public class StubContext : IZmqContext
	{
		private readonly Func<SocketType, StubSocket> _creator = (type) => new StubSocket(type);
		private bool _disposed;

		public event Action Disposing;
		public event Action Disposed;

		public StubContext()
		{
			this.LastSocketCreatedByType = new Dictionary<SocketType, StubSocket>();
		}

		public StubContext(Func<SocketType, StubSocket> creator) : this()
		{
			_creator = creator;
		}

		public IZmqSocket CreateSocket(SocketType type)
		{
			if (_disposed) throw new ObjectDisposedException("StubContext disposed");

			var socket = _creator(type);

			this.LastSocketCreatedByType[type] = socket;

			return socket;
		}

		public IZmqSocket CreateSocket(SocketType type, int rcvTimeoutInMilliseconds)
		{
			return CreateSocket(type);
		}

		public Dictionary<SocketType, StubSocket> LastSocketCreatedByType { get; private set; } 

		public void Dispose()
		{
			_disposed = true;
		}
	}
}