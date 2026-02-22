using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000005 RID: 5
	public class Resolver
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000023D4 File Offset: 0x000005D4
		public ~Resolver()
		{
			this.Dispose(false);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000218B File Offset: 0x0000038B
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000219D File Offset: 0x0000039D
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021AA File Offset: 0x000003AA
		public static IntPtr InitNative()
		{
			return Resolver.InitNativeDelegateField();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021B6 File Offset: 0x000003B6
		public static void ReleaseNative(IntPtr ptr)
		{
			Resolver.ReleaseNativeDelegateField(ptr);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021C3 File Offset: 0x000003C3
		public void Flush_Internal()
		{
			Resolver.Flush_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000021D5 File Offset: 0x000003D5
		public void Init_Internal(int width, int height)
		{
			Resolver.Init_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), width, height);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000021E9 File Offset: 0x000003E9
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000021F6 File Offset: 0x000003F6
		public int CurrentWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002203 File Offset: 0x00000403
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002210 File Offset: 0x00000410
		public int CurrentHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002408 File Offset: 0x00000608
		public void UpdateSize(int width, int height)
		{
			bool flag = this.CurrentWidth != width || this.CurrentHeight != height;
			if (flag)
			{
				this.CurrentWidth = width;
				this.CurrentHeight = height;
				this.Flush_Internal();
				this.Init_Internal(this.CurrentWidth, this.CurrentHeight);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002460 File Offset: 0x00000660
		public void Process(CommandBuffer cmd, RenderTargetIdentifier rt)
		{
			this.Process(cmd, rt, 0, this.CurrentWidth, 0, this.CurrentHeight, 0, 0);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000221D File Offset: 0x0000041D
		public void Process(CommandBuffer cmd, RenderTargetIdentifier rt, int x, int width, int y, int height, int mip, int slice)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000010 RID: 16
		private static readonly Resolver.InitNativeDelegate InitNativeDelegateField = IL2CPP.ResolveICall<Resolver.InitNativeDelegate>("UnityEngine.Rendering.VirtualTexturing.Resolver::InitNative");

		// Token: 0x04000011 RID: 17
		private static readonly Resolver.ReleaseNativeDelegate ReleaseNativeDelegateField = IL2CPP.ResolveICall<Resolver.ReleaseNativeDelegate>("UnityEngine.Rendering.VirtualTexturing.Resolver::ReleaseNative");

		// Token: 0x04000012 RID: 18
		private static readonly Resolver.Flush_InternalDelegate Flush_InternalDelegateField = IL2CPP.ResolveICall<Resolver.Flush_InternalDelegate>("UnityEngine.Rendering.VirtualTexturing.Resolver::Flush_Internal");

		// Token: 0x04000013 RID: 19
		private static readonly Resolver.Init_InternalDelegate Init_InternalDelegateField = IL2CPP.ResolveICall<Resolver.Init_InternalDelegate>("UnityEngine.Rendering.VirtualTexturing.Resolver::Init_Internal");

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000047 RID: 71
		private delegate IntPtr InitNativeDelegate();

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000049 RID: 73
		private delegate void ReleaseNativeDelegate(IntPtr ptr);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600004B RID: 75
		private delegate void Flush_InternalDelegate(IntPtr @this);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600004D RID: 77
		private delegate void Init_InternalDelegate(IntPtr @this, int width, int height);
	}
}
