using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200005E RID: 94
	public static class AppContextSwitches : Object
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x0003EC3C File Offset: 0x0003CE3C
		// Note: this type is marked as 'beforefieldinit'.
		static AppContextSwitches()
		{
			Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppContextSwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr);
			AppContextSwitches.NativeFieldInfoPtr_ThrowExceptionIfDisposedCancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "ThrowExceptionIfDisposedCancellationTokenSource");
			AppContextSwitches.NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "SetActorAsReferenceWhenCopyingClaimsIdentity");
			AppContextSwitches.NativeFieldInfoPtr_PreserveEventListnerObjectIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "PreserveEventListnerObjectIdentity");
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00004001 File Offset: 0x00002201
		public AppContextSwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0003ECA8 File Offset: 0x0003CEA8
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x0000400A File Offset: 0x0000220A
		public unsafe static bool ThrowExceptionIfDisposedCancellationTokenSource
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_ThrowExceptionIfDisposedCancellationTokenSource, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_ThrowExceptionIfDisposedCancellationTokenSource, (void*)(&value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0003ECC4 File Offset: 0x0003CEC4
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00004018 File Offset: 0x00002218
		public unsafe static bool SetActorAsReferenceWhenCopyingClaimsIdentity
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity, (void*)(&value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0003ECE0 File Offset: 0x0003CEE0
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00004026 File Offset: 0x00002226
		public unsafe static bool PreserveEventListnerObjectIdentity
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_PreserveEventListnerObjectIdentity, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_PreserveEventListnerObjectIdentity, (void*)(&value));
			}
		}

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr_ThrowExceptionIfDisposedCancellationTokenSource;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeFieldInfoPtr_PreserveEventListnerObjectIdentity;
	}
}
