﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Map
{
	public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
	{
		public void Configure(EntityTypeBuilder<UsuarioModel> builder)
		{
			builder.HasKey(x=>x.Id);
			builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
			builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
		}

		public void Configure(EntityTypeBuilder<TarefaModel> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Nome).HasMaxLength(255);
			builder.Property(x => x.Descricao).HasMaxLength(255);
			builder.Property(x => x.Status).IsRequired();
		}
	}
}
