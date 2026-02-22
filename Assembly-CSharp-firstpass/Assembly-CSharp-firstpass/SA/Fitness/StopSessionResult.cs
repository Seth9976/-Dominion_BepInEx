using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x02000346 RID: 838
	public class StopSessionResult : Result
	{
		// Token: 0x060032B1 RID: 12977 RVA: 0x000D39FC File Offset: 0x000D1BFC
		// Note: this type is marked as 'beforefieldinit'.
		static StopSessionResult()
		{
			Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "StopSessionResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr);
			StopSessionResult.NativeFieldInfoPtr_sessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr, "sessions");
			StopSessionResult.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr, "id");
			StopSessionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr, 100669797);
			StopSessionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr, 100669798);
			StopSessionResult.NativeMethodInfoPtr_AddSession_Public_Void_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr, 100669799);
			StopSessionResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr, 100669800);
			StopSessionResult.NativeMethodInfoPtr_get_Sessions_Public_get_List_1_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr, 100669801);
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x000D3AB8 File Offset: 0x000D1CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222748, XrefRangeEnd = 222755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopSessionResult(int id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x000D3B00 File Offset: 0x000D1D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222755, XrefRangeEnd = 222766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopSessionResult(int id, int resultCode, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopSessionResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x000D3B68 File Offset: 0x000D1D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222766, XrefRangeEnd = 222770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSession(Session session)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(session);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionResult.NativeMethodInfoPtr_AddSession_Public_Void_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x000D3BAC File Offset: 0x000D1DAC
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000D3BE8 File Offset: 0x000D1DE8
		public unsafe List<Session> Sessions
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionResult.NativeMethodInfoPtr_get_Sessions_Public_get_List_1_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Session>>(intPtr3) : null;
			}
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00013B65 File Offset: 0x00011D65
		public StopSessionResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000D3C28 File Offset: 0x000D1E28
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x00013B6E File Offset: 0x00011D6E
		public unsafe List<Session> sessions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionResult.NativeFieldInfoPtr_sessions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Session>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionResult.NativeFieldInfoPtr_sessions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x000D3C58 File Offset: 0x000D1E58
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x00013B8D File Offset: 0x00011D8D
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionResult.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionResult.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x04002F5C RID: 12124
		private static readonly IntPtr NativeFieldInfoPtr_sessions;

		// Token: 0x04002F5D RID: 12125
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F5E RID: 12126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002F5F RID: 12127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0;

		// Token: 0x04002F60 RID: 12128
		private static readonly IntPtr NativeMethodInfoPtr_AddSession_Public_Void_Session_0;

		// Token: 0x04002F61 RID: 12129
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F62 RID: 12130
		private static readonly IntPtr NativeMethodInfoPtr_get_Sessions_Public_get_List_1_Session_0;
	}
}
