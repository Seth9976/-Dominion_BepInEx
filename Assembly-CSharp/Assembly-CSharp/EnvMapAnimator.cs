using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;

// Token: 0x020000E0 RID: 224
public class EnvMapAnimator : MonoBehaviour
{
	// Token: 0x06001BF4 RID: 7156 RVA: 0x0006DB3C File Offset: 0x0006BD3C
	// Note: this type is marked as 'beforefieldinit'.
	static EnvMapAnimator()
	{
		Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EnvMapAnimator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr);
		EnvMapAnimator.NativeFieldInfoPtr_RotationSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr, "RotationSpeeds");
		EnvMapAnimator.NativeFieldInfoPtr_m_textMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr, "m_textMeshPro");
		EnvMapAnimator.NativeFieldInfoPtr_m_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr, "m_material");
		EnvMapAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr, 100665489);
		EnvMapAnimator.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr, 100665490);
		EnvMapAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr, 100665491);
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x0006DBE4 File Offset: 0x0006BDE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253378, XrefRangeEnd = 253381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvMapAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x0006DC18 File Offset: 0x0006BE18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253381, XrefRangeEnd = 253385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvMapAnimator.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x0006DC58 File Offset: 0x0006BE58
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EnvMapAnimator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvMapAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00011FDD File Offset: 0x000101DD
	public EnvMapAnimator(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170008FA RID: 2298
	// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x0006DC94 File Offset: 0x0006BE94
	// (set) Token: 0x06001BFA RID: 7162 RVA: 0x00011FE6 File Offset: 0x000101E6
	public unsafe Vector3 RotationSpeeds
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator.NativeFieldInfoPtr_RotationSpeeds);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator.NativeFieldInfoPtr_RotationSpeeds)) = value;
		}
	}

	// Token: 0x170008FB RID: 2299
	// (get) Token: 0x06001BFB RID: 7163 RVA: 0x0006DCBC File Offset: 0x0006BEBC
	// (set) Token: 0x06001BFC RID: 7164 RVA: 0x00012001 File Offset: 0x00010201
	public unsafe TMP_Text m_textMeshPro
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator.NativeFieldInfoPtr_m_textMeshPro);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator.NativeFieldInfoPtr_m_textMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008FC RID: 2300
	// (get) Token: 0x06001BFD RID: 7165 RVA: 0x0006DCEC File Offset: 0x0006BEEC
	// (set) Token: 0x06001BFE RID: 7166 RVA: 0x00012020 File Offset: 0x00010220
	public unsafe Material m_material
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator.NativeFieldInfoPtr_m_material);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator.NativeFieldInfoPtr_m_material), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040012DD RID: 4829
	private static readonly IntPtr NativeFieldInfoPtr_RotationSpeeds;

	// Token: 0x040012DE RID: 4830
	private static readonly IntPtr NativeFieldInfoPtr_m_textMeshPro;

	// Token: 0x040012DF RID: 4831
	private static readonly IntPtr NativeFieldInfoPtr_m_material;

	// Token: 0x040012E0 RID: 4832
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040012E1 RID: 4833
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x040012E2 RID: 4834
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000207 RID: 519
	[ObfuscatedName("EnvMapAnimator+<Start>d__4")]
	public sealed class _Start_d__4 : global::Il2CppSystem.Object
	{
		// Token: 0x06002932 RID: 10546 RVA: 0x00094868 File Offset: 0x00092A68
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__4()
		{
			Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvMapAnimator>.NativeClassPtr, "<Start>d__4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr);
			EnvMapAnimator._Start_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, "<>1__state");
			EnvMapAnimator._Start_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, "<>2__current");
			EnvMapAnimator._Start_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, "<>4__this");
			EnvMapAnimator._Start_d__4.NativeFieldInfoPtr__matrix_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, "<matrix>5__2");
			EnvMapAnimator._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, 100666534);
			EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, 100666535);
			EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, 100666536);
			EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, 100666537);
			EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, 100666538);
			EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr, 100666539);
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x0009495C File Offset: 0x00092B5C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Start_d__4(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvMapAnimator._Start_d__4>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvMapAnimator._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000949A4 File Offset: 0x00092BA4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000949D8 File Offset: 0x00092BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253362, XrefRangeEnd = 253373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x00094A14 File Offset: 0x00092C14
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x00094A54 File Offset: 0x00092C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253373, XrefRangeEnd = 253378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x00094A88 File Offset: 0x00092C88
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvMapAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00019605 File Offset: 0x00017805
		public _Start_d__4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x00094AC8 File Offset: 0x00092CC8
		// (set) Token: 0x0600293B RID: 10555 RVA: 0x0001960E File Offset: 0x0001780E
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator._Start_d__4.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator._Start_d__4.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x00094AF0 File Offset: 0x00092CF0
		// (set) Token: 0x0600293D RID: 10557 RVA: 0x00019629 File Offset: 0x00017829
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator._Start_d__4.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator._Start_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x00094B20 File Offset: 0x00092D20
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x00019648 File Offset: 0x00017848
		public unsafe EnvMapAnimator __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator._Start_d__4.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvMapAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator._Start_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x00094B50 File Offset: 0x00092D50
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x00019667 File Offset: 0x00017867
		public unsafe Matrix4x4 _matrix_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator._Start_d__4.NativeFieldInfoPtr__matrix_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvMapAnimator._Start_d__4.NativeFieldInfoPtr__matrix_5__2)) = value;
			}
		}

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeFieldInfoPtr__matrix_5__2;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
