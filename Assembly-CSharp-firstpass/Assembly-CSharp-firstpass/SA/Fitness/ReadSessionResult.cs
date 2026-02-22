using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x0200033F RID: 831
	public class ReadSessionResult : Result
	{
		// Token: 0x0600322C RID: 12844 RVA: 0x000D1F50 File Offset: 0x000D0150
		// Note: this type is marked as 'beforefieldinit'.
		static ReadSessionResult()
		{
			Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "ReadSessionResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr);
			ReadSessionResult.NativeFieldInfoPtr_sessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr, "sessions");
			ReadSessionResult.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr, "id");
			ReadSessionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr, 100669746);
			ReadSessionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr, 100669747);
			ReadSessionResult.NativeMethodInfoPtr_AddSession_Public_Void_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr, 100669748);
			ReadSessionResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr, 100669749);
			ReadSessionResult.NativeMethodInfoPtr_get_Sessions_Public_get_List_1_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr, 100669750);
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000D200C File Offset: 0x000D020C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222304, XrefRangeEnd = 222311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadSessionResult(int id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000D2054 File Offset: 0x000D0254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222311, XrefRangeEnd = 222322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadSessionResult(int id, int resultCode, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadSessionResult>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x000D20BC File Offset: 0x000D02BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222326, RefRangeEnd = 222327, XrefRangeStart = 222322, XrefRangeEnd = 222326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSession(Session session)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(session);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionResult.NativeMethodInfoPtr_AddSession_Public_Void_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x000D2100 File Offset: 0x000D0300
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x000D213C File Offset: 0x000D033C
		public unsafe List<Session> Sessions
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionResult.NativeMethodInfoPtr_get_Sessions_Public_get_List_1_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Session>>(intPtr3) : null;
			}
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00013738 File Offset: 0x00011938
		public ReadSessionResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06003233 RID: 12851 RVA: 0x000D217C File Offset: 0x000D037C
		// (set) Token: 0x06003234 RID: 12852 RVA: 0x00013741 File Offset: 0x00011941
		public unsafe List<Session> sessions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionResult.NativeFieldInfoPtr_sessions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Session>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionResult.NativeFieldInfoPtr_sessions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x000D21AC File Offset: 0x000D03AC
		// (set) Token: 0x06003236 RID: 12854 RVA: 0x00013760 File Offset: 0x00011960
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionResult.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionResult.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x04002F07 RID: 12039
		private static readonly IntPtr NativeFieldInfoPtr_sessions;

		// Token: 0x04002F08 RID: 12040
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F09 RID: 12041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002F0A RID: 12042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0;

		// Token: 0x04002F0B RID: 12043
		private static readonly IntPtr NativeMethodInfoPtr_AddSession_Public_Void_Session_0;

		// Token: 0x04002F0C RID: 12044
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F0D RID: 12045
		private static readonly IntPtr NativeMethodInfoPtr_get_Sessions_Public_get_List_1_Session_0;
	}
}
