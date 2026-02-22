using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000079 RID: 121
	public class Cursor : Object
	{
		// Token: 0x06000C28 RID: 3112 RVA: 0x00033BCC File Offset: 0x00031DCC
		// Note: this type is marked as 'beforefieldinit'.
		static Cursor()
		{
			Il2CppClassPointerStore<Cursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cursor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cursor>.NativeClassPtr);
			Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100663935);
			Cursor.get_visibleDelegateField = IL2CPP.ResolveICall<Cursor.get_visibleDelegate>("UnityEngine.Cursor::get_visible");
			Cursor.set_visibleDelegateField = IL2CPP.ResolveICall<Cursor.set_visibleDelegate>("UnityEngine.Cursor::set_visible");
			Cursor.set_lockStateDelegateField = IL2CPP.ResolveICall<Cursor.set_lockStateDelegate>("UnityEngine.Cursor::set_lockState");
			Cursor.SetCursor_InjectedDelegateField = IL2CPP.ResolveICall<Cursor.SetCursor_InjectedDelegate>("UnityEngine.Cursor::SetCursor_Injected");
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00033C4C File Offset: 0x00031E4C
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00008F86 File Offset: 0x00007186
		public unsafe static CursorLockMode lockState
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 64723, RefRangeEnd = 64726, XrefRangeStart = 64721, XrefRangeEnd = 64723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Cursor.set_lockStateDelegateField(value);
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00008F49 File Offset: 0x00007149
		public Cursor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00008F52 File Offset: 0x00007152
		public static void SetCursor(Texture2D texture, CursorMode cursorMode)
		{
			Cursor.SetCursor(texture, Vector2.zero, cursorMode);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00008F62 File Offset: 0x00007162
		public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
			Cursor.SetCursor_Injected(texture, ref hotspot, cursorMode);
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00008F6D File Offset: 0x0000716D
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00008F79 File Offset: 0x00007179
		public static bool visible
		{
			get
			{
				return Cursor.get_visibleDelegateField();
			}
			set
			{
				Cursor.set_visibleDelegateField(value);
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00008F93 File Offset: 0x00007193
		public static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode)
		{
			Cursor.SetCursor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(texture), ref hotspot, cursorMode);
		}

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0;

		// Token: 0x04000880 RID: 2176
		private static readonly Cursor.get_visibleDelegate get_visibleDelegateField;

		// Token: 0x04000881 RID: 2177
		private static readonly Cursor.set_visibleDelegate set_visibleDelegateField;

		// Token: 0x04000882 RID: 2178
		private static readonly Cursor.set_lockStateDelegate set_lockStateDelegateField;

		// Token: 0x04000883 RID: 2179
		private static readonly Cursor.SetCursor_InjectedDelegate SetCursor_InjectedDelegateField;

		// Token: 0x02000737 RID: 1847
		// (Invoke) Token: 0x06002C31 RID: 11313
		private delegate bool get_visibleDelegate();

		// Token: 0x02000738 RID: 1848
		// (Invoke) Token: 0x06002C33 RID: 11315
		private delegate void set_visibleDelegate(bool value);

		// Token: 0x02000739 RID: 1849
		// (Invoke) Token: 0x06002C35 RID: 11317
		private delegate void set_lockStateDelegate(CursorLockMode value);

		// Token: 0x0200073A RID: 1850
		// (Invoke) Token: 0x06002C37 RID: 11319
		private delegate void SetCursor_InjectedDelegate(IntPtr texture, IntPtr hotspot, CursorMode cursorMode);
	}
}
