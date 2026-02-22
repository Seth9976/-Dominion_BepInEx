using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000E RID: 14
	public class GooglePlayProrationMode : Object
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00006C34 File Offset: 0x00004E34
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayProrationMode()
		{
			Il2CppClassPointerStore<GooglePlayProrationMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayProrationMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayProrationMode>.NativeClassPtr);
			GooglePlayProrationMode.NativeFieldInfoPtr_k_NullProrationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayProrationMode>.NativeClassPtr, "k_NullProrationMode");
			GooglePlayProrationMode.NativeFieldInfoPtr_k_UnknownProrationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayProrationMode>.NativeClassPtr, "k_UnknownProrationMode");
			GooglePlayProrationMode.NativeFieldInfoPtr_k_ImmediateWithoutProration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayProrationMode>.NativeClassPtr, "k_ImmediateWithoutProration");
			GooglePlayProrationMode.NativeFieldInfoPtr_k_DeferredProrationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayProrationMode>.NativeClassPtr, "k_DeferredProrationMode");
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021F7 File Offset: 0x000003F7
		public GooglePlayProrationMode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00006CB4 File Offset: 0x00004EB4
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002200 File Offset: 0x00000400
		public unsafe static int k_NullProrationMode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayProrationMode.NativeFieldInfoPtr_k_NullProrationMode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayProrationMode.NativeFieldInfoPtr_k_NullProrationMode, (void*)(&value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00006CD0 File Offset: 0x00004ED0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000220E File Offset: 0x0000040E
		public unsafe static int k_UnknownProrationMode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayProrationMode.NativeFieldInfoPtr_k_UnknownProrationMode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayProrationMode.NativeFieldInfoPtr_k_UnknownProrationMode, (void*)(&value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00006CEC File Offset: 0x00004EEC
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000221C File Offset: 0x0000041C
		public unsafe static int k_ImmediateWithoutProration
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayProrationMode.NativeFieldInfoPtr_k_ImmediateWithoutProration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayProrationMode.NativeFieldInfoPtr_k_ImmediateWithoutProration, (void*)(&value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006D08 File Offset: 0x00004F08
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000222A File Offset: 0x0000042A
		public unsafe static int k_DeferredProrationMode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayProrationMode.NativeFieldInfoPtr_k_DeferredProrationMode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayProrationMode.NativeFieldInfoPtr_k_DeferredProrationMode, (void*)(&value));
			}
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_k_NullProrationMode;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_k_UnknownProrationMode;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_k_ImmediateWithoutProration;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_k_DeferredProrationMode;
	}
}
