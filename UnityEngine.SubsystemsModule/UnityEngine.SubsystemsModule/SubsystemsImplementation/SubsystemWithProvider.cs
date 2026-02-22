using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SubsystemsImplementation
{
	// Token: 0x0200000E RID: 14
	public class SubsystemWithProvider : Object
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00002483 File Offset: 0x00000683
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemWithProvider()
		{
			Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine.SubsystemsImplementation", "SubsystemWithProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr);
			SubsystemWithProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr, 100663324);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000036E8 File Offset: 0x000018E8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubsystemWithProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemWithProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000024BC File Offset: 0x000006BC
		public SubsystemWithProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000024C5 File Offset: 0x000006C5
		public void Start()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000024D2 File Offset: 0x000006D2
		public void Stop()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003724 File Offset: 0x00001924
		public void Destroy()
		{
			this.Stop();
			bool flag = SubsystemManager.RemoveStandaloneSubsystem(this);
			if (flag)
			{
				this.OnDestroy();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000024DF File Offset: 0x000006DF
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000024EC File Offset: 0x000006EC
		public bool running
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000024F9 File Offset: 0x000006F9
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002506 File Offset: 0x00000706
		public SubsystemProvider providerBase
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

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
