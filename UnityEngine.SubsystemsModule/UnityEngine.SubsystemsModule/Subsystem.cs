using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class Subsystem : Object
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000021A0 File Offset: 0x000003A0
		// Note: this type is marked as 'beforefieldinit'.
		static Subsystem()
		{
			Il2CppClassPointerStore<Subsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "Subsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Subsystem>.NativeClassPtr);
			Subsystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subsystem>.NativeClassPtr, 100663305);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002B78 File Offset: 0x00000D78
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Subsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Subsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subsystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021D9 File Offset: 0x000003D9
		public Subsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002BB4 File Offset: 0x00000DB4
		public void Destroy()
		{
			bool flag = SubsystemManager.RemoveDeprecatedSubsystem(this);
			if (flag)
			{
				this.OnDestroy();
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
