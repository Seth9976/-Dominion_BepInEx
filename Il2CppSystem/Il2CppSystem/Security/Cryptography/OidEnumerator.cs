using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200007C RID: 124
	public sealed class OidEnumerator : Object
	{
		// Token: 0x060007EF RID: 2031 RVA: 0x0002D878 File Offset: 0x0002BA78
		// Note: this type is marked as 'beforefieldinit'.
		static OidEnumerator()
		{
			Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "OidEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr);
			OidEnumerator.NativeFieldInfoPtr_m_oids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, "m_oids");
			OidEnumerator.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, "m_current");
			OidEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_OidCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100664322);
			OidEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100664323);
			OidEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100664324);
			OidEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100664325);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0002D920 File Offset: 0x0002BB20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41420, RefRangeEnd = 41422, XrefRangeStart = 41419, XrefRangeEnd = 41420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OidEnumerator(OidCollection oids)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oids);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_OidCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0002D96C File Offset: 0x0002BB6C
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41422, XrefRangeEnd = 41424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0002D9AC File Offset: 0x0002BBAC
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0002D9E8 File Offset: 0x0002BBE8
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000053D4 File Offset: 0x000035D4
		public OidEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0002DA1C File Offset: 0x0002BC1C
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x000053DD File Offset: 0x000035DD
		public unsafe OidCollection m_oids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr_m_oids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr_m_oids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0002DA4C File Offset: 0x0002BC4C
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x000053FC File Offset: 0x000035FC
		public unsafe int m_current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr_m_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr_m_current)) = value;
			}
		}

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr_m_oids;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_m_current;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_OidCollection_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
