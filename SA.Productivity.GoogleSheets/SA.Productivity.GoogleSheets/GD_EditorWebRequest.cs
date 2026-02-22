using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Networking;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x02000003 RID: 3
	public class GD_EditorWebRequest : Object
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00003428 File Offset: 0x00001628
		// Note: this type is marked as 'beforefieldinit'.
		static GD_EditorWebRequest()
		{
			Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_EditorWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr);
			GD_EditorWebRequest.NativeFieldInfoPtr_OnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, "OnComplete");
			GD_EditorWebRequest.NativeFieldInfoPtr_OnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, "OnUpdate");
			GD_EditorWebRequest.NativeFieldInfoPtr_m_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, "m_request");
			GD_EditorWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, 100663322);
			GD_EditorWebRequest.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, 100663323);
			GD_EditorWebRequest.NativeMethodInfoPtr_Send_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, 100663324);
			GD_EditorWebRequest.NativeMethodInfoPtr_get_Request_Public_get_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, 100663325);
			GD_EditorWebRequest.NativeMethodInfoPtr_get_DataAsText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, 100663326);
			GD_EditorWebRequest.NativeMethodInfoPtr_OnEditorUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, 100663327);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000350C File Offset: 0x0000170C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125448, XrefRangeEnd = 125474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_EditorWebRequest(string url)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003558 File Offset: 0x00001758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125474, XrefRangeEnd = 125499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_EditorWebRequest(UnityWebRequest request)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000035A4 File Offset: 0x000017A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125499, XrefRangeEnd = 125505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Send(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.NativeMethodInfoPtr_Send_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000035E8 File Offset: 0x000017E8
		public unsafe UnityWebRequest Request
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.NativeMethodInfoPtr_get_Request_Public_get_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003628 File Offset: 0x00001828
		public unsafe string DataAsText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125505, XrefRangeEnd = 125508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.NativeMethodInfoPtr_get_DataAsText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003660 File Offset: 0x00001860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125508, XrefRangeEnd = 125511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEditorUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.NativeMethodInfoPtr_OnEditorUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000206B File Offset: 0x0000026B
		public GD_EditorWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003694 File Offset: 0x00001894
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe Action OnComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_EditorWebRequest.NativeFieldInfoPtr_OnComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_EditorWebRequest.NativeFieldInfoPtr_OnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000036C4 File Offset: 0x000018C4
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002093 File Offset: 0x00000293
		public unsafe Action OnUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_EditorWebRequest.NativeFieldInfoPtr_OnUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_EditorWebRequest.NativeFieldInfoPtr_OnUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000036F4 File Offset: 0x000018F4
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000020B2 File Offset: 0x000002B2
		public unsafe UnityWebRequest m_request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_EditorWebRequest.NativeFieldInfoPtr_m_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_EditorWebRequest.NativeFieldInfoPtr_m_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_OnComplete;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_OnUpdate;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_m_request;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Void_Action_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_UnityWebRequest_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_DataAsText_Public_get_String_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_OnEditorUpdate_Private_Void_0;

		// Token: 0x02000021 RID: 33
		[ObfuscatedName("SA.Productivity.GoogleSheets.GD_EditorWebRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000121 RID: 289 RVA: 0x00006CD0 File Offset: 0x00004ED0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GD_EditorWebRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr);
				GD_EditorWebRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, "<>9");
				GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, "<>9__3_0");
				GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, "<>9__3_1");
				GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, "<>9__4_0");
				GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, "<>9__4_1");
				GD_EditorWebRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, 100663436);
				GD_EditorWebRequest.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, 100663437);
				GD_EditorWebRequest.__c.NativeMethodInfoPtr___ctor_b__3_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, 100663438);
				GD_EditorWebRequest.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, 100663439);
				GD_EditorWebRequest.__c.NativeMethodInfoPtr___ctor_b__4_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr, 100663440);
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00006DC4 File Offset: 0x00004FC4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_EditorWebRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00006E00 File Offset: 0x00005000
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__3_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00006E34 File Offset: 0x00005034
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__3_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.__c.NativeMethodInfoPtr___ctor_b__3_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00006E68 File Offset: 0x00005068
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00006E9C File Offset: 0x0000509C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__4_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_EditorWebRequest.__c.NativeMethodInfoPtr___ctor_b__4_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00002647 File Offset: 0x00000847
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000128 RID: 296 RVA: 0x00006ED0 File Offset: 0x000050D0
			// (set) Token: 0x06000129 RID: 297 RVA: 0x00002650 File Offset: 0x00000850
			public unsafe static GD_EditorWebRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GD_EditorWebRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600012A RID: 298 RVA: 0x00006EF8 File Offset: 0x000050F8
			// (set) Token: 0x0600012B RID: 299 RVA: 0x00002662 File Offset: 0x00000862
			public unsafe static Action __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600012C RID: 300 RVA: 0x00006F20 File Offset: 0x00005120
			// (set) Token: 0x0600012D RID: 301 RVA: 0x00002674 File Offset: 0x00000874
			public unsafe static Action __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600012E RID: 302 RVA: 0x00006F48 File Offset: 0x00005148
			// (set) Token: 0x0600012F RID: 303 RVA: 0x00002686 File Offset: 0x00000886
			public unsafe static Action __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000130 RID: 304 RVA: 0x00006F70 File Offset: 0x00005170
			// (set) Token: 0x06000131 RID: 305 RVA: 0x00002698 File Offset: 0x00000898
			public unsafe static Action __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GD_EditorWebRequest.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000E5 RID: 229
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000E6 RID: 230
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040000E7 RID: 231
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040000E8 RID: 232
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040000E9 RID: 233
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040000EA RID: 234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000EB RID: 235
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_0_Internal_Void_0;

			// Token: 0x040000EC RID: 236
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_1_Internal_Void_0;

			// Token: 0x040000ED RID: 237
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Internal_Void_0;

			// Token: 0x040000EE RID: 238
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_1_Internal_Void_0;
		}
	}
}
