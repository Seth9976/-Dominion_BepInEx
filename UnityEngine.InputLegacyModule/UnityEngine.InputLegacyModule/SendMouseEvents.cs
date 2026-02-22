using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class SendMouseEvents : Object
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00003700 File Offset: 0x00001900
		// Note: this type is marked as 'beforefieldinit'.
		static SendMouseEvents()
		{
			Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "SendMouseEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr);
			SendMouseEvents.NativeFieldInfoPtr_s_MouseUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MouseUsed");
			SendMouseEvents.NativeFieldInfoPtr_m_LastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_LastHit");
			SendMouseEvents.NativeFieldInfoPtr_m_MouseDownHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_MouseDownHit");
			SendMouseEvents.NativeFieldInfoPtr_m_CurrentHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_CurrentHit");
			SendMouseEvents.NativeFieldInfoPtr_m_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_Cameras");
			SendMouseEvents.NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663340);
			SendMouseEvents.NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663341);
			SendMouseEvents.NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663342);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000037D0 File Offset: 0x000019D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83547, XrefRangeEnd = 83551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMouseMoved()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000037F8 File Offset: 0x000019F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83551, XrefRangeEnd = 83663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoSendMouseEvents(int skipRTCameras)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipRTCameras;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000382C File Offset: 0x00001A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83781, RefRangeEnd = 83782, XrefRangeStart = 83663, XrefRangeEnd = 83781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEvents(int i, SendMouseEvents.HitInfo hit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hit));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000229E File Offset: 0x0000049E
		public SendMouseEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003878 File Offset: 0x00001A78
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000022A7 File Offset: 0x000004A7
		public unsafe static bool s_MouseUsed
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseUsed, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseUsed, (void*)(&value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003894 File Offset: 0x00001A94
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000022B5 File Offset: 0x000004B5
		public unsafe static Il2CppReferenceArray<SendMouseEvents.HitInfo> m_LastHit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_LastHit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendMouseEvents.HitInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_LastHit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000038BC File Offset: 0x00001ABC
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000022C7 File Offset: 0x000004C7
		public unsafe static Il2CppReferenceArray<SendMouseEvents.HitInfo> m_MouseDownHit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_MouseDownHit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendMouseEvents.HitInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_MouseDownHit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000038E4 File Offset: 0x00001AE4
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000022D9 File Offset: 0x000004D9
		public unsafe static Il2CppReferenceArray<SendMouseEvents.HitInfo> m_CurrentHit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_CurrentHit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendMouseEvents.HitInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_CurrentHit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000390C File Offset: 0x00001B0C
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000022EB File Offset: 0x000004EB
		public unsafe static Il2CppReferenceArray<Camera> m_Cameras
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_Cameras, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_Cameras, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_s_MouseUsed;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_m_LastHit;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseDownHit;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentHit;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_m_Cameras;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0;

		// Token: 0x0400007A RID: 122
		public const int m_HitIndexGUI = 0;

		// Token: 0x0400007B RID: 123
		public const int m_HitIndexPhysics3D = 1;

		// Token: 0x0400007C RID: 124
		public const int m_HitIndexPhysics2D = 2;

		// Token: 0x0200002A RID: 42
		public sealed class HitInfo : ValueType
		{
			// Token: 0x060000DF RID: 223 RVA: 0x00003B10 File Offset: 0x00001D10
			// Note: this type is marked as 'beforefieldinit'.
			static HitInfo()
			{
				Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "HitInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr);
				SendMouseEvents.HitInfo.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, "target");
				SendMouseEvents.HitInfo.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, "camera");
				SendMouseEvents.HitInfo.NativeMethodInfoPtr_SendMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, 100663344);
				SendMouseEvents.HitInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, 100663345);
				SendMouseEvents.HitInfo.NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, 100663346);
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x00003BA0 File Offset: 0x00001DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83538, XrefRangeEnd = 83539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SendMessage(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.HitInfo.NativeMethodInfoPtr_SendMessage_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00003BE8 File Offset: 0x00001DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83539, XrefRangeEnd = 83543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator bool(SendMouseEvents.HitInfo exists)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(exists));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.HitInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00003C30 File Offset: 0x00001E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83543, XrefRangeEnd = 83547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.HitInfo.NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x000024E0 File Offset: 0x000006E0
			public HitInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x000024E9 File Offset: 0x000006E9
			public HitInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr))
			{
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x00003C90 File Offset: 0x00001E90
			// (set) Token: 0x060000E6 RID: 230 RVA: 0x000024FB File Offset: 0x000006FB
			public unsafe GameObject target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x00003CC0 File Offset: 0x00001EC0
			// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000251A File Offset: 0x0000071A
			public unsafe Camera camera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_camera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400009B RID: 155
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400009C RID: 156
			private static readonly IntPtr NativeFieldInfoPtr_camera;

			// Token: 0x0400009D RID: 157
			private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_0;

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0;
		}
	}
}
